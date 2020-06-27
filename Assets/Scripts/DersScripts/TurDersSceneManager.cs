using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurDersSceneManager : MonoBehaviour
{
    public GameObject TurDersPnl1, TurDersPnl2;
    public void TurDersPanel1Change()
    {
        if (GameObject.FindGameObjectWithTag("DevamBtn"))
        {
            TurDersPnl1.SetActive(false);
            TurDersPnl2.SetActive(true);
        }
    }

    public void TurPanelGeri1()
    {
        if (GameObject.FindGameObjectWithTag("Button"))
        {
            TurDersPnl2.SetActive(false);
            TurDersPnl1.SetActive(true);
        }
    }

    public void TurDersPnlOyunaGecis()
    {
        if (GameObject.FindGameObjectWithTag("DevamBtn"))
        {
            SceneManager.LoadScene("TurScene");
        }
    }
}
