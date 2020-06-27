using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject startBtn, exitBtn;
    void Start()
    {
        FadeOut();
    }

    void FadeOut()
    {
        startBtn.GetComponent<CanvasGroup>().DOFade(1, 2f);
        exitBtn.GetComponent<CanvasGroup>().DOFade(1, 2f);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SecenekScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
