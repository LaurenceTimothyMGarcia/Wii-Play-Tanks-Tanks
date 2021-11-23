using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class LevelReader : MonoBehaviour
{
    //added this to test something - larry
    public static string filePath = "Assets/Levels/Level";
    public static string levelNumber = "Level001.level";
    public static string levelPath;
    public string levelName;
    public string mode;
    public Vector3 startTopLeft;
    public Vector2 levelSize;
    public string levelData;
    public GameObject cameraPosition;
    public Camera cameraSize;

    public float cameraX = 0.53f;
    public float cameraY = 15.1f;
    public float cameraZ = -2.22f;
    public float cameraS = 8.43f;

    public GameObject wallSmall;
    public GameObject wallMedium;
    public GameObject wallTall;
    public GameObject wallcornerUL;
    public GameObject wallcornerUR;
    public GameObject wallcornerBL;
    public GameObject wallcornerBR;
    public GameObject desWall1;
    public GameObject desWall2_UNUSED;
    public GameObject desWall3_UNUSED;
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
        levelPath = Application.dataPath + "/Levels/" + levelNumber;
        Debug.Log(levelPath);
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
        
        try { //Just in case, try to read again, for a custom camera position
            cameraX = float.Parse(levelReader.ReadLine());
            cameraY = float.Parse(levelReader.ReadLine());
            cameraZ = float.Parse(levelReader.ReadLine());
            cameraS = float.Parse(levelReader.ReadLine());
        }
        catch{
            Debug.Log("No camera data found.");
        }
        Vector3 newCamPos = new Vector3(cameraX, cameraY, cameraZ);
        try { //If data is found, set the camera accordingly
            cameraPosition.transform.position = newCamPos;
            cameraSize.orthographicSize = cameraS; //Also set size of camera
        }
        catch {
            Debug.LogError("Failed to modify camera.");
        }

        if (Working)
        {
            GameObject levelTileHolder = GameObject.Find("TileHolder");

            for (int i = 0; i < height; i++) //change y axis
            {
                for (int j = 0; j < width; j += 2) //change x axis
                {
                    currentTile = levelData.Substring(j + (width * i), 2); //get tile
                    if (currentTile.Substring(0, 1).Equals("1")) //If it's a wall
                    {
                        int currentTileInt = int.Parse(currentTile.Substring(1)); //get the height value
                        //Instantiate(wall, GetComponent<Transform>().position + new Vector3(0, (currentTileInt - (float)4) / 2, 0), GetComponent<Transform>().rotation, levelTileHolder.transform); OLD CODE BASED ON CHANGING HEIGHT
                        switch (currentTileInt)
                        {
                            case 0: //Short wall
                                Instantiate(wallSmall, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 1: //Mid wall
                                Instantiate(wallMedium, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 2: //Tall wall
                                Instantiate(wallTall, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 3: //corner up left wall
                                Instantiate(wallcornerUL, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 4: //corner up left wall
                                Instantiate(wallcornerUR, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 5: //corner up left wall
                                Instantiate(wallcornerBL, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 6: //corner up left wall
                                Instantiate(wallcornerBR, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            default: //Nonexistant wall
                                break;
                        }
                    }
                    else if (currentTile.Substring(0, 1).Equals("2")) //Ditto for destructable walls
                    {
                        int currentTileInt = int.Parse(currentTile.Substring(1));
                        //Instantiate(desWall, GetComponent<Transform>().position + new Vector3(0, (currentTileInt - (float)4) / 2, 0), GetComponent<Transform>().rotation, levelTileHolder.transform); OLD CODE BASED ON CHANGING HEIGHT
                        switch (currentTileInt)
                        {
                            case 0: //Short Break
                                Instantiate(desWall1, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 1:
                                Instantiate(desWall2_UNUSED, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
                                break;
                            case 2:
                                Instantiate(desWall3_UNUSED, GetComponent<Transform>().position, GetComponent<Transform>().rotation, levelTileHolder.transform);
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
        GetComponent<Transform>().position = startTopLeft; //Reset pen head
        
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
