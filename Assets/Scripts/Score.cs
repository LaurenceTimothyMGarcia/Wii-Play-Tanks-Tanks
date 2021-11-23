using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int enemyNum;
    public Text enemyLeftText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyNum = GameObject.FindGameObjectsWithTag("Enemy").Length;

        enemyLeftText.text = "Enemies Left: " + (enemyNum/2);
    }
}
