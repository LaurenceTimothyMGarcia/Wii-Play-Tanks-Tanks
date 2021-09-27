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

    public Vector3 startTopLeft;
    public Vector2 levelSize;

    public GameObject wall;
    public GameObject desWall;
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

    public void BuildLevel(string path) //Uses indirect path in directory to get level
    {
        levelReader = new StreamReader(path);
        GetComponent<Transform>().position = startTopLeft; //Put "pen" to start
        levelName = levelReader.ReadLine(); //Get name of level for displaying
        mode = levelReader.ReadLine(); //Get mode (Singleplayer, Multiplayer Co-Op, Multiplayer Versus)
        levelSize.x = int.Parse(levelReader.ReadLine()); //Get level width
        int width = (int)levelSize.x*2; //Doubled for tile size of 2 chars
        levelSize.y = int.Parse(levelReader.ReadLine()); //Get level height
        int height = (int)levelSize.y; //Saved as height for clarity

        levelData = levelReader.ReadLine(); //Finally, get level data
        for (int i = 0; i < height; i++) //change y axis
        {
            for (int j = 0; j < width; j += 2) //change x axis
            {
                currentTile = levelData.Substring(j + (width*i), 2); //get tile
                if (currentTile.Substring(0, 1).Equals("1"))
                {
                    int currentTileInt = int.Parse(currentTile.Substring(1)); //If it's a wall, get the height value
                    switch (currentTileInt)
                    {
                        case 1:
                            Instantiate(wall, GetComponent<Transform>().position + new Vector3(0, (float)-1.5, 0), GetComponent<Transform>().rotation);
                            break;
                        case 2:
                            Instantiate(wall, GetComponent<Transform>().position + new Vector3(0, -1, 0), GetComponent<Transform>().rotation);
                            break;
                        case 3:
                            Instantiate(wall, GetComponent<Transform>().position + new Vector3(0, (float)-0.5, 0), GetComponent<Transform>().rotation);
                            break;
                        case 4:
                            Instantiate(wall, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        default:
                            break;
                    }
                }
                else if (currentTile.Substring(0, 1).Equals("2")) //Ditto for destructable walls
                {
                    int currentTileInt = int.Parse(currentTile.Substring(1));
                    switch (currentTileInt)
                    {
                        case 1:
                            Instantiate(desWall, GetComponent<Transform>().position + new Vector3(0, (float)-1.5, 0), GetComponent<Transform>().rotation);
                            break;
                        case 2:
                            Instantiate(desWall, GetComponent<Transform>().position + new Vector3(0, -1, 0), GetComponent<Transform>().rotation);
                            break;
                        case 3:
                            Instantiate(desWall, GetComponent<Transform>().position + new Vector3(0, (float)-0.5, 0), GetComponent<Transform>().rotation);
                            break;
                        case 4:
                            Instantiate(desWall, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        default:
                            break;
                    }
                }
                else if (currentTile.Substring(0, 1).Equals("e") && mode.Equals("MultiplayerVersus")) //Ditto for enemys
                {
                    int currentTileInt = int.Parse(currentTile.Substring(1));
                    switch (currentTileInt)
                    {
                        case 0:
                            Instantiate(brownTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        case 1:
                            Instantiate(greyTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        case 2:
                            Instantiate(turqTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        case 3:
                            Instantiate(yellowTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        case 4:
                            Instantiate(tealTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        case 5:
                            Instantiate(greenTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        case 6:
                            Instantiate(purpTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        case 7:
                            Instantiate(whiteTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        case 8:
                            Instantiate(blackTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        case 9:
                            Instantiate(thomasTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (currentTile) //Otherwise, fallback to string-based switch statement
                    {
                        case "00": //Draw nothing
                            break;
                        case "-1":
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
                        default: //Malformed names and other nonsense is ignored
                            break;
                    }
                }
                GetComponent<Transform>().position += Vector3.right; //Next tile
            }
            GetComponent<Transform>().position += new Vector3(-22, 0, 0);
            GetComponent<Transform>().position += Vector3.back;
        }
        //GetComponent<Transform>().position = new Vector3(-10, 0, 19); //Reset pen head
    }
}
