using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject saatPanel, turPanel, zamanPanel;

    public void SaatPanelOpen()
    {
        if (GameObject.FindGameObjectWithTag("SaatBtn"))
        {
            saatPanel.SetActive(true);
        }
    }

    public void TurPanelOpen()
    {
        if (GameObject.FindGameObjectWithTag("Button"))
        {
            turPanel.SetActive(true);
        }
    }

    public void ZamanPanelOpen()
    {
        if (GameObject.FindGameObjectWithTag("Button"))
        {
            zamanPanel.SetActive(true);
        }
    }

    public void SaatDersSceneOpen()
    {
        SceneManager.LoadScene("SaatDersScene");
    }

    public void SaatGameSceneOpen()
    {
        SceneManager.LoadScene("SaatScene");
    }

    public void TurSceneOpen()
    {
        SceneManager.LoadScene("TurScene");
    }

    public void ZamanSceneOpen()
    {
        SceneManager.LoadScene("ZamanScene");
    }

    public void GameSceneOpen()
    {
        SceneManager.LoadScene("GameScene");
    }
}
