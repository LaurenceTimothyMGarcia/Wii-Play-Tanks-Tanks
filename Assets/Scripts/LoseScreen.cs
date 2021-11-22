using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    public GameObject loseMenu;
    public static bool lost;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        LevelReader.levelPath = LevelReader.levelPath;
        SceneManager.LoadScene("LevelEditor");
        loseMenu.SetActive(false);
    }

    public void GoToMainMenu()
    {
        lost = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        loseMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
