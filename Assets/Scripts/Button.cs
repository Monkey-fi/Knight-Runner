using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void FirstScene()
    {
        SceneManager.LoadScene(0);
    }

    public void SparshScene()
    {
        SceneManager.LoadScene(1);
    } 

    public void AryanScene()
    {
        SceneManager.LoadScene(2);
    }

    public void HarshitScene()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadingScene()
    {
        SceneManager.LoadScene(4);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(5);
    }

    public void Score()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
