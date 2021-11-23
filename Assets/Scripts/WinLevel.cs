using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{
    public GameObject winMenu;
    public static bool win;

    void Start()
    {
        win = false;
        Time.timeScale = 1f;
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

        //AVAST, ALL WHO HOPED THAT I WOULDN'T USE REGEX
        Regex getLevelNumber = new Regex(@"\d{3}");
        Match levelNameNumbers = getLevelNumber.Match(LevelReader.levelNumber);
        if (levelNameNumbers.Success)
        {
            int parseLevelMatch = int.Parse(levelNameNumbers.Value);
            parseLevelMatch++;
            string levelNumberString = parseLevelMatch.ToString();
            LevelReader.levelNumber = "Level";
            for (int i = 0; i < 3 - levelNumberString.Length; i++)
            {
                LevelReader.levelNumber = string.Concat(LevelReader.levelNumber, "0");
            }
            LevelReader.levelNumber = string.Concat(LevelReader.levelNumber, parseLevelMatch.ToString() + ".level");
            Debug.Log("Win level filepath " + LevelReader.levelNumber);
        }
        else
        {
            GoToMainMenu();
        }
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
