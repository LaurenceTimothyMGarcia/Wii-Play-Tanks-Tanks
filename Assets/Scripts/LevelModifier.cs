using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelModifier : MonoBehaviour
{
    StreamWriter levelWriter;
    
    
    // Start is called before the first frame update
    void Start()
    {
        MakeLevel("Assets/Levels/", "TestWrite", "Write Test", "Singleplayer", 5, 1, "00sp0000-1");
    }
    public void MakeLevel(string pathFolder, string fileName, string levelName, string Mode, int width, int height, string levelData) {
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
