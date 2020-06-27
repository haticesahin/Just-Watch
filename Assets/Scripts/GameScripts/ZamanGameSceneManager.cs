using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ZamanGameSceneManager : MonoBehaviour
{
    public GameObject[] Paneller = new GameObject[4];
    private int sayi;
    public GameObject DogruPnl, YanlisPnl;
    private int can = 2, soruSayisi = 0;
    public Text canText;
    public float dolum, dolumHizi = 1f, maxDolum = 6f;
    public GameObject Dolum;

    void Start()
    {
        RandomSayiUretme();
    }

    public void RandomSayiUretme()
    {
        System.Random randomSayi = new System.Random();
        sayi = randomSayi.Next(4);
        Debug.Log("random sayi ..........." + sayi);
        Paneller[sayi].SetActive(true);
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
            CanSay();
        }
    }

    public void DevamBtnClick()
    {
        DogruPnl.SetActive(false);
        YanlisPnl.SetActive(false);
        Paneller[sayi].SetActive(false);
        RandomSayiUretme();
        SoruSayisi();
        DolumSay();
    }

    public void CanSay()
    {
        can--;
        canText.text = can.ToString();
        if (can == 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

    public void SoruSayisi()
    {
        soruSayisi++;
        if (soruSayisi == 6)
        {
            SceneManager.LoadScene("WinScene");
        }
    }

    public void DolumSay()
    {
        dolum++;
        Dolum.transform.localScale = new Vector2(dolum / maxDolum, 1);
        if (dolum <= 0)
        {
            dolum = 0;
        }
        if (dolum > 6)
        {
            dolum = maxDolum;
        }
    }

}

