using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class LevelReader : MonoBehaviour
{
    public string levelPath;
    public string LevelName;
    public string currentString;
    string currentSection;

    StreamReader levelReader;
    char buffer;

    // Start is called before the first frame update
    void Start()
    {
        BuildLevel(levelPath);
    }

    void BuildLevel(string path) //Uses indirect path in directory to get level
    {
        levelReader = new StreamReader(path);
        GetComponent<Transform>().position = new Vector3(-10, 0, 19);
        LevelName = levelReader.ReadLine(); //Get name of level for displaying
        for (int i = 0; i < 16; i++) //change y axis
        {
            currentString = levelReader.ReadLine();
            for (int j = 0; j < 80; j += 5) //change x axis
            {
                currentSection = currentString.Substring(j, 5); //get tile
                switch(figureOutTile(currentSection))
                {
                    case 0:
                        break;
                }

            }
        }
    }

    int figureOutTile(string input) { //wait I can totally just do this in the switch statement lmao
        return 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
