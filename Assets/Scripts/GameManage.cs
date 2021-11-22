using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public float beforeStartTime = 60f;

    bool paused = true;

    // Start is called before the first frame update
    void Awake()
    {
        //paused = true;
        //Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //beforeStartTime -= Time.deltaTime;

        /*if (Input.GetKeyDown(KeyCode.E))
        {
            //paused = false;
            Time.timeScale = 1f;
        }*/
    }
}
