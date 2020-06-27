using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TouchScript : MonoBehaviour
{
    private bool dragItem = false;
    private GameObject dragObject;
    private Vector3 touchOffset;

    void Update()
    {
        if (HasInput)
        {
            Drag();
        }
        else
        {
            if (dragItem)
            {
                Drop();
            }
        }
    }

    private bool HasInput
    {
        get
        { 
            return Input.GetMouseButton(0); 
        }
    }

    private void Drag()
    {
        var InputPosition = Position;
        if (dragItem)
        {
            dragObject.transform.position = InputPosition + touchOffset;
        }
        else
        {
            RaycastHit[] touches = Physics.RaycastAll(InputPosition, InputPosition, 0.5f);
            if (touches.Length > 0)
            {
                var hit = touches[0];
                if(hit.transform != null && hit.transform.gameObject.tag != "Button")
                {
                    dragItem = true;
                    dragObject = hit.transform.gameObject;
                    touchOffset = (Vector3)hit.transform.position - InputPosition;
                    dragObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
            }
        }
    }

    Vector3 Position
    {
        get { return Camera.main.ScreenToWorldPoint(Input.mousePosition); }
    }

    void Drop()
    {
        dragItem = false;
        dragObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

    }
}
