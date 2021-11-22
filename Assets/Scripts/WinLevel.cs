using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{
    public GameObject winMenu;
    public static bool win;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (win)
        {
            YouWin();
        }
        else
        {
            winMenu.SetActive(false);
        }
    }

    public void YouWin()
    {
        winMenu.SetActive(true);
        Time.timeScale = 0f;
        win = true;
    }

    public void NextLevel()//try to get it to next level file
    {
        win = false;
        Time.timeScale = 1f;
        LevelReader.levelPath = LevelReader.levelPath;
        winMenu.SetActive(false);
        SceneManager.LoadScene("LevelEditor");
    }

    public void GoToMainMenu()
    {
        win = false;
        Time.timeScale = 1f;
        winMenu.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void ConvertIntString()//trying to make it set to the next level in line
    {

    }
}
