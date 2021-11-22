using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public GameObject level0120;
    public GameObject level2140;
    public GameObject level4160;
    public GameObject level6180;
    public GameObject level9110;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level0120()
    {
        level0120.SetActive(true);
        level2140.SetActive(false);
        level4160.SetActive(false);
        level6180.SetActive(false);
        level9110.SetActive(false);
    }

    public void Level2140()
    {
        level0120.SetActive(false);
        level2140.SetActive(true);
        level4160.SetActive(false);
        level6180.SetActive(false);
        level9110.SetActive(false);
    }

    public void Level4160()
    {
        level0120.SetActive(false);
        level2140.SetActive(false);
        level4160.SetActive(true);
        level6180.SetActive(false);
        level9110.SetActive(false);
    }

    public void Level6180()
    {
        level0120.SetActive(false);
        level2140.SetActive(false);
        level4160.SetActive(false);
        level6180.SetActive(true);
        level9110.SetActive(false);
    }

    public void Level81100()
    {
        level0120.SetActive(false);
        level2140.SetActive(false);
        level4160.SetActive(false);
        level6180.SetActive(false);
        level9110.SetActive(true);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Level001()
    {
        LevelReader.levelPath = "Assets/Levels/Level001.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level002()
    {
        LevelReader.levelPath = "Assets/Levels/Level002.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level003()
    {
        LevelReader.levelPath = "Assets/Levels/Level003.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level004()
    {
        LevelReader.levelPath = "Assets/Levels/Level004.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level005()
    {
        LevelReader.levelPath = "Assets/Levels/Level005.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level006()
    {
        LevelReader.levelPath = "Assets/Levels/Level006.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level007()
    {
        LevelReader.levelPath = "Assets/Levels/Level007.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level008()
    {
        LevelReader.levelPath = "Assets/Levels/Level008.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level009()
    {
        LevelReader.levelPath = "Assets/Levels/Level009.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level010()
    {
        LevelReader.levelPath = "Assets/Levels/Level010.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level011()
    {
        LevelReader.levelPath = "Assets/Levels/Level011.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level012()
    {
        LevelReader.levelPath = "Assets/Levels/Level012.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level013()
    {
        LevelReader.levelPath = "Assets/Levels/Level013.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level014()
    {
        LevelReader.levelPath = "Assets/Levels/Level014.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level015()
    {
        LevelReader.levelPath = "Assets/Levels/Level015.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level016()
    {
        LevelReader.levelPath = "Assets/Levels/Level016.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level017()
    {
        LevelReader.levelPath = "Assets/Levels/Level017.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level018()
    {
        LevelReader.levelPath = "Assets/Levels/Level018.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level019()
    {
        LevelReader.levelPath = "Assets/Levels/Level019.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level020()
    {
        LevelReader.levelPath = "Assets/Levels/Level020.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level021()
    {
        LevelReader.levelPath = "Assets/Levels/Level021.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level022()
    {
        LevelReader.levelPath = "Assets/Levels/Level022.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level023()
    {
        LevelReader.levelPath = "Assets/Levels/Level023.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level024()
    {
        LevelReader.levelPath = "Assets/Levels/Level024.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level025()
    {
        LevelReader.levelPath = "Assets/Levels/Level025.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level026()
    {
        LevelReader.levelPath = "Assets/Levels/Level026.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level027()
    {
        LevelReader.levelPath = "Assets/Levels/Level027.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level028()
    {
        LevelReader.levelPath = "Assets/Levels/Level028.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level029()
    {
        LevelReader.levelPath = "Assets/Levels/Level029.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level030()
    {
        LevelReader.levelPath = "Assets/Levels/Level030.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level031()
    {
        LevelReader.levelPath = "Assets/Levels/Level031.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level032()
    {
        LevelReader.levelPath = "Assets/Levels/Level032.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level033()
    {
        LevelReader.levelPath = "Assets/Levels/Level033.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level034()
    {
        LevelReader.levelPath = "Assets/Levels/Level034.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level035()
    {
        LevelReader.levelPath = "Assets/Levels/Level035.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level036()
    {
        LevelReader.levelPath = "Assets/Levels/Level036.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level037()
    {
        LevelReader.levelPath = "Assets/Levels/Level037.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level038()
    {
        LevelReader.levelPath = "Assets/Levels/Level038.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level039()
    {
        LevelReader.levelPath = "Assets/Levels/Level039.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level040()
    {
        LevelReader.levelPath = "Assets/Levels/Level040.level";
        SceneManager.LoadScene("LevelEditor");
    }
}
