using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public GameObject loseMenu;
    public static bool lost;

    // Update is called once per frame
    void Update()
    {
        if (lost)
        {
            YouLose();
        }
        else
        {
            loseMenu.SetActive(false);
        }
    }

    public void YouLose()
    {
        loseMenu.SetActive(true);
        Time.timeScale = 0f;
        lost = true;
    }

    public void RestartLevel()
    {
        lost = false;
        Time.timeScale = 1f;
        loseMenu.SetActive(false);
        SceneManager.LoadScene("LevelEditor");
    }

    public void GoToMainMenu()
    {
        lost = false;
        Time.timeScale = 1f;
        loseMenu.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
