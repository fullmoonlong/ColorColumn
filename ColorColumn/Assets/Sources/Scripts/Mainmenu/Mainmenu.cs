using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    private void Awake()
    {
        Screen.SetResolution(2560, 1080, true);
    }

    public void Continue()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        BoardMatch.clickCount = 0;
        RowClick.SetMyColor(new Color32(255, 255, 255, 255));
        ColumnClick.SetMyColor(new Color32(255, 255, 255, 255));
        PlayerPrefs.GetInt("Levels");
        SceneManager.LoadScene("Game");
    }

    public void LevelSelect()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        BoardMatch.clickCount = 0;
        RowClick.SetMyColor(new Color32(255, 255, 255, 255));
        ColumnClick.SetMyColor(new Color32(255, 255, 255, 255));
        SceneManager.LoadScene("LevelSelect");
    }
    
    public void Credit()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        SceneManager.LoadScene("Credit");
    }

    public void Exit()
    {
        BoardMatch.clickCount = 0;
        RowClick.SetMyColor(new Color32(255, 255, 255, 255));
        ColumnClick.SetMyColor(new Color32(255, 255, 255, 255));
        Application.Quit();
    }
}
