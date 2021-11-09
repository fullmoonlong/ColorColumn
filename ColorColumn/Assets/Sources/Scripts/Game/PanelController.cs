using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelController : MonoBehaviour
{
    static bool isInSetting;
    public GameObject settingPanel, clearPanel, failPanel, pauseEffect;

    private void Awake()
    {
        isInSetting = false;
    }
    public void Menu()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        BoardMatch.clickCount = 0;
        SceneManager.LoadScene("Mainmenu");
    }

    public void NextLevel()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        clearPanel.SetActive(false);
        PlayerPrefs.GetInt("Levels");
        Reload();
    }

    public void RetryLevel()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        failPanel.SetActive(false);
        Reload();
    }
    public void SettingClick()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        if (!isInSetting)
        {
            settingPanel.SetActive(true);
            pauseEffect.SetActive(true);
            isInSetting = true;
        }
        else if (isInSetting)
        {
            settingPanel.SetActive(false);
            pauseEffect.SetActive(false);
            isInSetting = false;
        }
    }

    void Reload()
    {
        BoardMatch.clickCount = 0;
        RowClick.SetMyColor(new Color32(255, 255, 255, 255));
        ColumnClick.SetMyColor(new Color32(255, 255, 255, 255));
        SceneManager.LoadScene("Game");
    }
}
