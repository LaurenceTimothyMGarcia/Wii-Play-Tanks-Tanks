using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MainGame()
    {
        SceneManager.LoadScene("LevelEditor");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelectScreen");
    }

    public void TitleMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void About()
    {
        SceneManager.LoadScene("About");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
