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

    public void Level041()
    {
        LevelReader.levelPath = "Assets/Levels/Level041.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level042()
    {
        LevelReader.levelPath = "Assets/Levels/Level042.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level043()
    {
        LevelReader.levelPath = "Assets/Levels/Level043.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level044()
    {
        LevelReader.levelPath = "Assets/Levels/Level044.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level045()
    {
        LevelReader.levelPath = "Assets/Levels/Level045.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level046()
    {
        LevelReader.levelPath = "Assets/Levels/Level046.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level047()
    {
        LevelReader.levelPath = "Assets/Levels/Level047.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level048()
    {
        LevelReader.levelPath = "Assets/Levels/Level048.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level049()
    {
        LevelReader.levelPath = "Assets/Levels/Level049.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level050()
    {
        LevelReader.levelPath = "Assets/Levels/Level050.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level051()
    {
        LevelReader.levelPath = "Assets/Levels/Level051.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level052()
    {
        LevelReader.levelPath = "Assets/Levels/Level052.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level053()
    {
        LevelReader.levelPath = "Assets/Levels/Level053.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level054()
    {
        LevelReader.levelPath = "Assets/Levels/Level054.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level055()
    {
        LevelReader.levelPath = "Assets/Levels/Level055.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level056()
    {
        LevelReader.levelPath = "Assets/Levels/Level056.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level057()
    {
        LevelReader.levelPath = "Assets/Levels/Level057.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level058()
    {
        LevelReader.levelPath = "Assets/Levels/Level058.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level059()
    {
        LevelReader.levelPath = "Assets/Levels/Level059.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level060()
    {
        LevelReader.levelPath = "Assets/Levels/Level060.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level061()
    {
        LevelReader.levelPath = "Assets/Levels/Level061.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level062()
    {
        LevelReader.levelPath = "Assets/Levels/Level062.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level063()
    {
        LevelReader.levelPath = "Assets/Levels/Level063.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level064()
    {
        LevelReader.levelPath = "Assets/Levels/Level064.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level065()
    {
        LevelReader.levelPath = "Assets/Levels/Level065.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level066()
    {
        LevelReader.levelPath = "Assets/Levels/Level066.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level067()
    {
        LevelReader.levelPath = "Assets/Levels/Level067.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level068()
    {
        LevelReader.levelPath = "Assets/Levels/Level068.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level069()
    {
        LevelReader.levelPath = "Assets/Levels/Level069.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level070()
    {
        LevelReader.levelPath = "Assets/Levels/Level070.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level071()
    {
        LevelReader.levelPath = "Assets/Levels/Level071.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level072()
    {
        LevelReader.levelPath = "Assets/Levels/Level072.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level073()
    {
        LevelReader.levelPath = "Assets/Levels/Level073.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level074()
    {
        LevelReader.levelPath = "Assets/Levels/Level074.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level075()
    {
        LevelReader.levelPath = "Assets/Levels/Level075.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level076()
    {
        LevelReader.levelPath = "Assets/Levels/Level076.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level077()
    {
        LevelReader.levelPath = "Assets/Levels/Level077.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level078()
    {
        LevelReader.levelPath = "Assets/Levels/Level078.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level079()
    {
        LevelReader.levelPath = "Assets/Levels/Level079.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level080()
    {
        LevelReader.levelPath = "Assets/Levels/Level080.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level081()
    {
        LevelReader.levelPath = "Assets/Levels/Level081.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level082()
    {
        LevelReader.levelPath = "Assets/Levels/Level082.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level083()
    {
        LevelReader.levelPath = "Assets/Levels/Level083.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level084()
    {
        LevelReader.levelPath = "Assets/Levels/Level084.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level085()
    {
        LevelReader.levelPath = "Assets/Levels/Level085.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level086()
    {
        LevelReader.levelPath = "Assets/Levels/Level086.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level087()
    {
        LevelReader.levelPath = "Assets/Levels/Level087.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level088()
    {
        LevelReader.levelPath = "Assets/Levels/Level088.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level089()
    {
        LevelReader.levelPath = "Assets/Levels/Level089.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level090()
    {
        LevelReader.levelPath = "Assets/Levels/Level090.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level091()
    {
        LevelReader.levelPath = "Assets/Levels/Level091.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level092()
    {
        LevelReader.levelPath = "Assets/Levels/Level092.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level093()
    {
        LevelReader.levelPath = "Assets/Levels/Level093.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level094()
    {
        LevelReader.levelPath = "Assets/Levels/Level094.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level095()
    {
        LevelReader.levelPath = "Assets/Levels/Level095.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level096()
    {
        LevelReader.levelPath = "Assets/Levels/Level096.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level097()
    {
        LevelReader.levelPath = "Assets/Levels/Level097.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level098()
    {
        LevelReader.levelPath = "Assets/Levels/Level098.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level099()
    {
        LevelReader.levelPath = "Assets/Levels/Level099.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level100()
    {
        LevelReader.levelPath = "Assets/Levels/Level100.level";
        SceneManager.LoadScene("LevelEditor");
    }
}
