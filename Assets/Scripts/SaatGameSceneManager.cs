using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SaatGameSceneManager : MonoBehaviour
{
    public GameObject[] Paneller = new GameObject[4];
    private int sayi;
    public GameObject DogruPnl, YanlisPnl;

    void Start()
    {
        GamePanelChange();
    }

    public void RandomSayiUretme()
    {
        System.Random randomSayi = new System.Random();
        sayi = randomSayi.Next(5);
        Debug.Log(sayi);
    }

    public void GamePanelChange()
    {
        if (sayi <= 4)
        {
            Paneller[sayi].SetActive(true);
            
        }
    }

    public void DogruBtnClick()
    {
        if (GameObject.FindGameObjectWithTag("DogruBtn"))
        {
            DogruPnl.SetActive(true);
        }
    }

    public void YanlisBtnClick()
    {
        if (GameObject.FindGameObjectWithTag("Button"))
        {
            YanlisPnl.SetActive(true);
        }
    }

    public void DevamBtnClick()
    {
        DogruPnl.SetActive(false);
        YanlisPnl.SetActive(false);
        GamePanelChange();
    }
}
