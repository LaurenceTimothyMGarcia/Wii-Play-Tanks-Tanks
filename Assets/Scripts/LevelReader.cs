using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class LevelReader : MonoBehaviour
{
    public string levelPath;
    public string levelName;
    public string mode;
    public Vector3 startTopLeft;
    public Vector2 levelSize;
    public string levelData;
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
        //ClearLevel();
    }

    public void BuildLevel(string path) //Uses path in directory from Assets to get level
    {
        bool Working = true;
        try
        {
            levelReader = new StreamReader(path);
        }
        catch
        {
            Debug.LogError("File not found/Malformed path.");
            Working = false;
        }
        GetComponent<Transform>().position = startTopLeft; //Put "pen" to start
        try
        {
            levelName = levelReader.ReadLine(); //Get name of level for displaying
            mode = levelReader.ReadLine(); //Get mode (it should be Singleplayer, Multiplayer Co-Op, Multiplayer Versus)
            levelSize.x = int.Parse(levelReader.ReadLine()); //Get level width
            levelSize.y = int.Parse(levelReader.ReadLine()); //Get level height
        }
        catch
        {
            Debug.LogError("Bad header data.");
            Working = false;
        }
        int width = (int)levelSize.x * 2; //Doubled for tile size of 2 chars
        int height = (int)levelSize.y; //Saved as height for clarity
        try
        {
            levelData = levelReader.ReadLine(); //Finally, get level data
        }
        catch
        {
            Debug.LogError("Level data is missing.");
            Working = false;
        }
        if (levelData.Length != width * height) Working = false; //If the string isn't the same length as the product of the width and height, don't read.
        if (!mode.Equals("Singleplayer") && !mode.Equals("MultiplayerCoOp") && !mode.Equals("MultiplayerVersus")) Working = false; //If the mode is not supported, don't read.

        if (Working)
        {
            GameObject levelTileHolder = GameObject.Find("TileHolder");

            for (int i = 0; i < height; i++) //change y axis
            {
                for (int j = 0; j < width; j += 2) //change x axis
                {
                    currentTile = levelData.Substring(j + (width * i), 2); //get tile
                    if (currentTile.Substring(0, 1).Equals("1"))
                    {
                        int currentTileInt = int.Parse(currentTile.Substring(1)); //If it's a wall, get the height value
                        switch (currentTileInt)
                        {
                            case 1:
                                Instantiate(wall, GetComponent<Transform>().position + new Vector3(0, (float)-1.5, 0), GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 2:
                                Instantiate(wall, GetComponent<Transform>().position + new Vector3(0, -1, 0), GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 3:
                                Instantiate(wall, GetComponent<Transform>().position + new Vector3(0, (float)-0.5, 0), GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 4:
                                Instantiate(wall, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
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
                                Instantiate(desWall, GetComponent<Transform>().position + new Vector3(0, (float)-1.5, 0), GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 2:
                                Instantiate(desWall, GetComponent<Transform>().position + new Vector3(0, -1, 0), GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 3:
                                Instantiate(desWall, GetComponent<Transform>().position + new Vector3(0, (float)-0.5, 0), GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 4:
                                Instantiate(desWall, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            default:
                                break;
                        }
                    }
                    else if (currentTile.Substring(0, 1).Equals("e") && !mode.Equals("MultiplayerVersus")) //Ditto for enemys
                    {
                        int currentTileInt = int.Parse(currentTile.Substring(1));
                        switch (currentTileInt)
                        {
                            case 0:
                                Instantiate(brownTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 1:
                                Instantiate(greyTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 2:
                                Instantiate(turqTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 3:
                                Instantiate(yellowTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 4:
                                Instantiate(tealTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 5:
                                Instantiate(greenTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 6:
                                Instantiate(purpTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 7:
                                Instantiate(whiteTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 8:
                                Instantiate(blackTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 9:
                                Instantiate(thomasTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
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
                                Instantiate(hole, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case "sp":
                                if (!mode.Equals("Singleplayer")) break; //Only in Singleplayer
                                else
                                {
                                    Instantiate(spTank, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                    break;
                                }
                            case "m0":
                                if (mode.Equals("Singleplayer")) break; //Only in Multiplayer
                                else
                                {
                                    Instantiate(mpTankP1, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                    break;
                                }
                            case "m1":
                                if (mode.Equals("Singleplayer")) break; //Ditto
                                else
                                {
                                    Instantiate(mpTankP2, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
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
        }
        else
        {
            Debug.LogError("Level data does not match in terms of length.");
        }
        //GetComponent<Transform>().position = new Vector3(-10, 0, 19); //Reset pen head
        levelReader.Close(); //Close levelReader
        levelReader.Dispose(); //Free up the space as well
    }
    
    public void ClearLevel() //Clear tileset of level
    {
        GameObject levelTileHolder = GameObject.Find("TileHolder");
        foreach (Transform child in levelTileHolder.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
