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
    }

    public void YouLose()
    {
        loseMenu.SetActive(true);
        Time.timeScale = 0f;
        lost = true;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        lost = false;
        LevelReader.levelPath = LevelReader.levelPath;
        SceneManager.LoadScene("LevelEditor");
        loseMenu.SetActive(false);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        lost = false;
        loseMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
