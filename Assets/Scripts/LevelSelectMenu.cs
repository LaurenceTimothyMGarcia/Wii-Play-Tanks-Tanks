using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public GameObject level0120;
    public GameObject level2140;
    public GameObject level4160;
    public GameObject level6180;
    public GameObject level9110;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level0120()
    {
        level0120.SetActive(true);
        level2140.SetActive(false);
        level4160.SetActive(false);
        level6180.SetActive(false);
        level9110.SetActive(false);
    }

    public void Level2140()
    {
        level0120.SetActive(false);
        level2140.SetActive(true);
        level4160.SetActive(false);
        level6180.SetActive(false);
        level9110.SetActive(false);
    }

    public void Level4160()
    {
        level0120.SetActive(false);
        level2140.SetActive(false);
        level4160.SetActive(true);
        level6180.SetActive(false);
        level9110.SetActive(false);
    }

    public void Level6180()
    {
        level0120.SetActive(false);
        level2140.SetActive(false);
        level4160.SetActive(false);
        level6180.SetActive(true);
        level9110.SetActive(false);
    }

    public void Level81100()
    {
        level0120.SetActive(false);
        level2140.SetActive(false);
        level4160.SetActive(false);
        level6180.SetActive(false);
        level9110.SetActive(true);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
