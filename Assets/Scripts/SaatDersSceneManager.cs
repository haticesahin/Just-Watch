using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaatDersSceneManager : MonoBehaviour
{
    public GameObject SaatDersPnl1, SaatDersPnl2, SaatDersPnl3, SaatDersPnl4, SaatDersPnl5, SaatDersPnl6;
    public bool AkrepBool, TamSaatAnExit;

    public void SaatDersPanel1Change()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl1.SetActive(false);
            SaatDersPnl2.SetActive(true);
        } 
    }

    public void SaatDersPanel2Change()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl2.SetActive(false);
            SaatDersPnl3.SetActive(true);
        }
    }

    public void SaatDersPanel3Change()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl3.SetActive(false);
            SaatDersPnl4.SetActive(true);
        }
    }

    public void SaatDersPanel4Change()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl4.SetActive(false);
            SaatDersPnl5.SetActive(true);
        }
    }

    public void SaatDersPanel5Change()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl5.SetActive(false);
            SaatDersPnl6.SetActive(true);
        }
    }

    public void SaatDersPnlOyunaGecis()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SceneManager.LoadScene("SaatScene");
        }
    }

    public void SaatPanelGeri1()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl2.SetActive(false);
            SaatDersPnl1.SetActive(true);
        } 
    }

    public void SaatPanelGeri2() { 
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl3.SetActive(false);
            SaatDersPnl2.SetActive(true);
        }
    }

    public void SaatPanelGeri3()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl4.SetActive(false);
            SaatDersPnl3.SetActive(true);
        }
    }

    public void SaatPanelGeri4()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl5.SetActive(false);
            SaatDersPnl4.SetActive(true);
        }
    }

    public void SaatPanelGeri5()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            SaatDersPnl6.SetActive(false);
            SaatDersPnl5.SetActive(true);
        }
    }



    //public void TamSaatAnimation()
    //{
    //    if (AkrepBool == true)
    //    {

    //    }
    //}
}
