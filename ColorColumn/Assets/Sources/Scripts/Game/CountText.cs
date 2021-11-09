using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountText : MonoBehaviour
{
    public Text count;

    int level1Limit = 9;
    int level2Limit = 7;
    int level3Limit = 9;
    int level4Limit = 9;
    int level5Limit = 11;
    int level6Limit = 8;
    int level7Limit = 15;

    // Update is called once per frame
    void Update()
    {
        if      (PlayerPrefs.GetInt("Levels") == 1)
            count.text = "Touch Left : " + (level1Limit - BoardMatch.clickCount);

        else if (PlayerPrefs.GetInt("Levels") == 2)
            count.text = "Touch Left : " + (level2Limit - BoardMatch.clickCount);

        else if (PlayerPrefs.GetInt("Levels") == 3)
            count.text = "Touch Left : " + (level3Limit - BoardMatch.clickCount);

        else if (PlayerPrefs.GetInt("Levels") == 4)
            count.text = "Touch Left : " + (level4Limit - BoardMatch.clickCount);

        else if (PlayerPrefs.GetInt("Levels") == 5)
            count.text = "Touch Left : " + (level5Limit - BoardMatch.clickCount);

        else if (PlayerPrefs.GetInt("Levels") == 6)
            count.text = "Touch Left : " + (level6Limit - BoardMatch.clickCount);

        else if (PlayerPrefs.GetInt("Levels") == 7)
            count.text = "Touch Left : " + (level7Limit - BoardMatch.clickCount);
    }
}
