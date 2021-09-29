using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelModifier : MonoBehaviour
{
    StreamWriter levelWriter;

    public string[,] levelDataArray = new string[10,10];
    // Start is called before the first frame update
    void Start()
    {
        //MakeLevel("Assets/Levels/", "TestWrite", "Write Test", "Singleplayer", 5, 1, "00sp0000-1");
        ShowLevelAsArray(new Vector2(22, 16), "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000-1-1-1-1-1-1-1000000000000000000000000000000-11100000011-1000000000000000000000000000000-10000210000-100000000000000000000000000sp00-11100000011-10000e000e100000000000000000000-11111111111-1000000000000000000000000000000-1-1-1-1-1-1-1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
    }
    public void MakeLevel(string pathFolder, string fileName, string levelName, string Mode, int width, int height, string levelData) { //Build .level file from data as string
        string trueFilePath = string.Concat(pathFolder, string.Concat(fileName, ".level")); //get the whole file path together
        if (File.Exists(trueFilePath))
        { 
           File.Copy(trueFilePath, string.Concat(trueFilePath, "old")); //Save the previous version
           File.Delete(trueFilePath);
        }
        levelWriter = new StreamWriter(trueFilePath); //Opens the new file (or creates it if nonexistent?)
        levelWriter.WriteLine(levelName);
        levelWriter.WriteLine(Mode);
        levelWriter.WriteLine(width);
        levelWriter.WriteLine(height);
        levelWriter.WriteLine(levelData);
        levelWriter.Close(); //Finished writing, close the writer
        levelWriter.Dispose();
    }


    public /*void*/ string[,] ShowLevelAsArray(Vector2 levelSize, string levelData) //Returns 2 dimensional array representation of level
    {
        levelDataArray = new string[levelData.Length/(2*(int)levelSize.y), levelData.Length/(2 * (int)levelSize.x)]; //Array is width tiles wide (as height factor is divided out), and height tiles long (ditto for width)
        for (int i = 0; i < (int)levelSize.y; i++) //Height [,x] incrementor
        {
            for (int j = 0; j < (int)levelSize.x; j++) //Width [x,] incrementor
            {
                levelDataArray[j, i] = levelData.Substring(j * 2 + (int)levelSize.y * i, 2); //Set each tiles in a two character substring of the data
            }
        }
        return levelDataArray;
    }
}
