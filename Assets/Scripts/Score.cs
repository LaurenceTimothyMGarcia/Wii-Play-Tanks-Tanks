using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public bool enemyCount;
    public bool scoreCount;

    int enemyNum;
    public static int score = 0;
    public Text enemyLeftText;
    public Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount)
        {
            enemyNum = GameObject.FindGameObjectsWithTag("Enemy").Length;
            enemyLeftText.text = "Enemies Left: " + (enemyNum/2);
        }

        if(scoreCount)
        {
            textScore.text = "Score: " + score;
        }
    }
}
