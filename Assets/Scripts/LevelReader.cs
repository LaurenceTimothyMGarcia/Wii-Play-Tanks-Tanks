using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class LevelReader : MonoBehaviour
{
    public string levelPath;
    public string levelName;
    public string mode;
    public string levelData;
    public GameObject wall;
    public GameObject wallTall;
    public GameObject wallTaller;
    public GameObject wallTallest;
    public GameObject desWall;
    public GameObject desWallTall;
    public GameObject desWallTaller;
    public GameObject desWallTallest;
    public GameObject hole;
    public GameObject spTank;
    public GameObject mpTankP1;
    public GameObject mpTankP2;
    public GameObject brownTank;
    public GameObject greyTank;
    public GameObject turqTank;
    public GameObject yellowTank;
    public GameObject tealTank;
    public GameObject greenTank;
    public GameObject purpTank;
    public GameObject whiteTank;
    public GameObject blackTank;
    public GameObject thomasTank;

    string currentTile;

    StreamReader levelReader;

    // Start is called before the first frame update
    void Start()
    {
        BuildLevel(levelPath);
    }

    void BuildLevel(string path) //Uses indirect path in directory to get level
    {
        levelReader = new StreamReader(path);
        Vector3 startPosition = new Vector3(-10, 0, 19); //Top left of the board
        GetComponent<Transform>().position = startPosition; //Put "pen" to start
        levelName = levelReader.ReadLine(); //Get name of level for displaying
        mode = levelReader.ReadLine();
        levelData = levelReader.ReadLine();
        for (int i = 0; i < 16; i++) //change y axis
        {
            for (int j = 0; j < 44; j += 2) //change x axis
            {
                currentTile = levelData.Substring(j + (44*i), 2); //get tile
                switch(currentTile)
                {
                    case "00": //Draw nothing
                        break;
                    case "-1":
                        break;
                    case "11":
                        Instantiate(wall, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                        break;
                    case "12":
                        Instantiate(wallTall, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                        break;
                    case "13":
                        Instantiate(wallTaller, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                        break;
                    case "14":
                        Instantiate(wallTallest, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                        break;
                    case "21":
                        Instantiate(desWall, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                        break;
                    case "22":
                        Instantiate(desWallTall, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                        break;
                    case "23":
                        Instantiate(desWallTaller, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                        break;
                    case "24":
                        Instantiate(desWallTallest, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                        break;
                    case "sp":
                        if (!mode.Equals("Singleplayer")) break; //Only in Singleplayer
                        else
                        {
                            Instantiate(spTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "m0":
                        if (mode.Equals("Singleplayer")) break; //Only in Multiplayer
                        else
                        {
                            Instantiate(mpTankP1, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "m1":
                        if (mode.Equals("Singleplayer")) break; //Ditto
                        else
                        {
                            Instantiate(mpTankP2, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e0":
                        if (mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(brownTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e1":
                        if (mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(greyTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e2":
                        if (mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(turqTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e3":
                        if (mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(yellowTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e4":
                        if (mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(tealTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e5":
                        if (mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(greenTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e6":
                        if (mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(purpTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e7":
                        if (mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(whiteTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e8":
                        if (mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(blackTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    case "e9":
                        if(mode.Equals("MultiplayerVersus")) break;
                        else
                        {
                            Instantiate(thomasTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        }
                    default: //Malformed names and other nonsense is ignored
                        break;
                }
                GetComponent<Transform>().position += Vector3.right; //Next tile
            }
            GetComponent<Transform>().position += new Vector3(-22, 0, 0);
            GetComponent<Transform>().position += Vector3.back;
        }
        //GetComponent<Transform>().position = new Vector3(-10, 0, 19); //Reset pen head
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
