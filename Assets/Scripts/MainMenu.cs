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

    }

    public void About()
    {

    }

    public void Exit()
    {
        Application.Quit();
    }
}
