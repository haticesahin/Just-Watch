using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZamanDersSceneManager : MonoBehaviour
{
    public GameObject ZamanDersPnl1, ZamanDersPnl2, ZamanDersPnl3;
    public void ZamanDersPanel1Change()
    {
        if (GameObject.FindGameObjectWithTag("DevamBtn"))
        {
            ZamanDersPnl1.SetActive(false);
            ZamanDersPnl2.SetActive(true);
        }
    }

    public void ZamanDersPanel2Change()
    {
        if (GameObject.FindGameObjectWithTag("DevamBtn"))
        {
            ZamanDersPnl2.SetActive(false);
            ZamanDersPnl3.SetActive(true);
        }
    }

    public void ZamanPanelGeri1()
    {
        if (GameObject.FindGameObjectWithTag("Button"))
        {
            ZamanDersPnl2.SetActive(false);
            ZamanDersPnl1.SetActive(true);
        }
    }

    public void ZamanPanelGeri2()
    {
        if (GameObject.FindGameObjectWithTag("Button"))
        {
            ZamanDersPnl3.SetActive(false);
            ZamanDersPnl2.SetActive(true);
        }
    }
    public void ZamanDersPnlOyunaGecis()
    {
        if (GameObject.FindGameObjectWithTag("DevamBtn"))
        {
            SceneManager.LoadScene("ZamanScene");
        }
    }
}
