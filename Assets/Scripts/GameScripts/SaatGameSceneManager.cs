using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SaatGameSceneManager : MonoBehaviour
{
    //public int[] Paneldizi = new int[8];
    public GameObject[] Paneller = new GameObject[8];
    private int sayi;
    public GameObject DogruPnl, YanlisPnl;
    public int yanlis = 0, can = 5, soruSayisi=0;
    public Text canText;
    public GameObject yelkovan;
    public float dolum, dolumHizi=1f, maxDolum=15f;
    public GameObject Dolum;

    void Start()
    {
        RandomSayiUretme();
    }

    public void RandomSayiUretme()
    {
        System.Random randomSayi = new System.Random();
        sayi = randomSayi.Next(8);
        Debug.Log("random sayi ..........."+sayi);
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
        if(soruSayisi == 15)
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
        if (dolum > 15)
        {
            dolum = maxDolum;
        }
    }

    public void OnCollisionEnter(Collision nesne)
    {
        if (nesne.gameObject.tag == "DogruBtn")
        {
            DogruPnl.SetActive(true);
        }
        else
        {
            YanlisPnl.SetActive(true);
            CanSay();
        }
    }

    public void Cevir()
    {
        if (GameObject.FindGameObjectWithTag("Button"))
        {
            yelkovan.transform.Rotate(new Vector3(0, 0, 90));
        }
    }

    //     for (int i=0; i <= Paneldizi.Length; i++) //i=1;
    //        {
    //            sayi = randomSayi.Next(5);
    //            Debug.Log("sayi1..................." + sayi);
    //            for(int j=0; j<i; j++)
    //            {
    //                if (Paneldizi[j] ==sayi)
    //                {
    //                    Debug.Log("sayi2..............." + j);
    //                    Debug.Log("j..............." + j);
    //                    i--;
    //                    Paneller[sayi].SetActive(true);
    //    Debug.Log("sayi ..........." + sayi);
    //                    break;
    //                }
    //                else
    //                {
    //                    Paneldizi[i] = sayi;
    //                    Paneller[sayi].SetActive(true);
    //Debug.Log("i ..........." + sayi);
    //                }
    //            }
    //        }
}
