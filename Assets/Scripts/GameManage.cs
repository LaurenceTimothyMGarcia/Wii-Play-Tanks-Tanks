using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public float beforeStartTime = 60f;

    float musicStart = 2f;

    bool once = true;
    int enemyNum;
    int playerNum;


    void Start()
    {
        FindObjectOfType<AudioManager>().Play("RoundStart");
    }

    // Update is called once per frame
    void Update()
    {
        musicStart -= Time.deltaTime;
        if (musicStart <= 0 && once)
        {
            FindObjectOfType<AudioManager>().Play("Theme1");
            once = false;
        }

        //beforeStartTime -= Time.deltaTime;

        /*if (Input.GetKeyDown(KeyCode.E))
        {
            //paused = false;
            Time.timeScale = 1f;
        }*/

        enemyNum = GameObject.FindGameObjectsWithTag("Enemy").Length;
        playerNum = GameObject.FindGameObjectsWithTag("Player").Length;

        if (enemyNum <= 0)
        {
            FindObjectOfType<AudioManager>().Play("RoundEnd");
            WinLevel.win = true;
        }

        //if (Time.frameCount % 500 == 0)
        //Debug.Log(playerNum);
        if (playerNum <= 0)
        {
            FindObjectOfType<AudioManager>().Play("RoundFail");
            LoseScreen.lost = true;
        }
    }
}
