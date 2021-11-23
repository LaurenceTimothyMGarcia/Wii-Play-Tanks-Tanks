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
        LevelReader.levelNumber = "Level001.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level002()
    {
        LevelReader.levelNumber = "Level002.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level003()
    {
        LevelReader.levelNumber = "Level003.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level004()
    {
        LevelReader.levelNumber = "Level004.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level005()
    {
        LevelReader.levelNumber = "Level005.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level006()
    {
        LevelReader.levelNumber = "Level006.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level007()
    {
        LevelReader.levelNumber = "Level007.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level008()
    {
        LevelReader.levelNumber = "Level008.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level009()
    {
        LevelReader.levelNumber = "Level009.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level010()
    {
        LevelReader.levelNumber = "Level010.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level011()
    {
        LevelReader.levelNumber = "Level011.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level012()
    {
        LevelReader.levelNumber = "Level012.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level013()
    {
        LevelReader.levelNumber = "Level013.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level014()
    {
        LevelReader.levelNumber = "Level014.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level015()
    {
        LevelReader.levelNumber = "Level015.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level016()
    {
        LevelReader.levelNumber = "Level016.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level017()
    {
        LevelReader.levelNumber = "Level017.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level018()
    {
        LevelReader.levelNumber = "Level018.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level019()
    {
        LevelReader.levelNumber = "Level019.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level020()
    {
        LevelReader.levelNumber = "Level020.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level021()
    {
        LevelReader.levelNumber = "Level021.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level022()
    {
        LevelReader.levelNumber = "Level022.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level023()
    {
        LevelReader.levelNumber = "Level023.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level024()
    {
        LevelReader.levelNumber = "Level024.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level025()
    {
        LevelReader.levelNumber = "Level025.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level026()
    {
        LevelReader.levelNumber = "Level026.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level027()
    {
        LevelReader.levelNumber = "Level027.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level028()
    {
        LevelReader.levelNumber = "Level028.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level029()
    {
        LevelReader.levelNumber = "Level029.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level030()
    {
        LevelReader.levelNumber = "Level030.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level031()
    {
        LevelReader.levelNumber = "Level031.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level032()
    {
        LevelReader.levelNumber = "Level032.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level033()
    {
        LevelReader.levelNumber = "Level033.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level034()
    {
        LevelReader.levelNumber = "Level034.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level035()
    {
        LevelReader.levelNumber = "Level035.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level036()
    {
        LevelReader.levelNumber = "Level036.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level037()
    {
        LevelReader.levelNumber = "Level037.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level038()
    {
        LevelReader.levelNumber = "Level038.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level039()
    {
        LevelReader.levelNumber = "Level039.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level040()
    {
        LevelReader.levelNumber = "Level040.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level041()
    {
        LevelReader.levelNumber = "Level041.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level042()
    {
        LevelReader.levelNumber = "Level042.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level043()
    {
        LevelReader.levelNumber = "Level043.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level044()
    {
        LevelReader.levelNumber = "Level044.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level045()
    {
        LevelReader.levelNumber = "Level045.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level046()
    {
        LevelReader.levelNumber = "Level046.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level047()
    {
        LevelReader.levelNumber = "Level047.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level048()
    {
        LevelReader.levelNumber = "Level048.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level049()
    {
        LevelReader.levelNumber = "Level049.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level050()
    {
        LevelReader.levelNumber = "Level050.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level051()
    {
        LevelReader.levelNumber = "Level051.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level052()
    {
        LevelReader.levelNumber = "Level052.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level053()
    {
        LevelReader.levelNumber = "Level053.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level054()
    {
        LevelReader.levelPath = "Assets/Levels/Level054.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level055()
    {
        LevelReader.levelNumber = "Level055.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level056()
    {
        LevelReader.levelNumber = "Level056.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level057()
    {
        LevelReader.levelNumber = "Level057.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level058()
    {
        LevelReader.levelNumber = "Level058.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level059()
    {
        LevelReader.levelNumber = "Level059.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level060()
    {
        LevelReader.levelNumber = "Level060.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level061()
    {
        LevelReader.levelNumber = "Level061.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level062()
    {
        LevelReader.levelNumber = "Level062.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level063()
    {
        LevelReader.levelNumber = "Level063.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level064()
    {
        LevelReader.levelNumber = "Level064.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level065()
    {
        LevelReader.levelNumber = "Level065.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level066()
    {
        LevelReader.levelNumber = "Level066.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level067()
    {
        LevelReader.levelNumber = "Level067.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level068()
    {
        LevelReader.levelNumber = "Level068.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level069()
    {
        LevelReader.levelNumber = "Level069.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level070()
    {
        LevelReader.levelNumber = "Level070.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level071()
    {
        LevelReader.levelNumber = "Level071.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level072()
    {
        LevelReader.levelNumber = "Level072.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level073()
    {
        LevelReader.levelNumber = "Level073.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level074()
    {
        LevelReader.levelNumber = "Level074.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level075()
    {
        LevelReader.levelNumber = "Level075.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level076()
    {
        LevelReader.levelNumber = "Level076.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level077()
    {
        LevelReader.levelNumber = "Level077.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level078()
    {
        LevelReader.levelNumber = "Level078.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level079()
    {
        LevelReader.levelNumber = "Level079.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level080()
    {
        LevelReader.levelNumber = "Level080.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level081()
    {
        LevelReader.levelNumber = "Level081.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level082()
    {
        LevelReader.levelNumber = "Level082.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level083()
    {
        LevelReader.levelNumber = "Level083.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level084()
    {
        LevelReader.levelNumber = "Level084.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level085()
    {
        LevelReader.levelNumber = "Level085.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level086()
    {
        LevelReader.levelNumber = "Level086.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level087()
    {
        LevelReader.levelNumber = "Level087.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level088()
    {
        LevelReader.levelNumber = "Level088.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level089()
    {
        LevelReader.levelNumber = "Level089.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level090()
    {
        LevelReader.levelNumber = "Level090.level";
        SceneManager.LoadScene("LevelEditor");
    }

    public void Level091()
    {
        LevelReader.levelNumber = "Level091.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level092()
    {
        LevelReader.levelNumber = "Level092.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level093()
    {
        LevelReader.levelNumber = "Level093.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level094()
    {
        LevelReader.levelNumber = "Level094.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level095()
    {
        LevelReader.levelNumber = "Level095.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level096()
    {
        LevelReader.levelNumber = "Level096.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level097()
    {
        LevelReader.levelNumber = "Level097.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level098()
    {
        LevelReader.levelNumber = "Level098.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level099()
    {
        LevelReader.levelNumber = "Level099.level";
        SceneManager.LoadScene("LevelEditor");
    }
    public void Level100()
    {
        LevelReader.levelNumber = "Level100.level";
        SceneManager.LoadScene("LevelEditor");
    }
}
