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

    public void HarshitScene()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadingScene()
    {
        SceneManager.LoadScene(3);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(4);
    }
    
    public void LevelScene()
    {
        SceneManager.LoadScene(5);
    }

    public void Score()
    {
        SceneManager.LoadScene(6);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public GameObject pausePanel;

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void ContinuePlay()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
