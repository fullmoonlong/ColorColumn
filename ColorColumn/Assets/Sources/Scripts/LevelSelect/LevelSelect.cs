using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void LoadMainMenu()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        BoardMatch.clickCount = 0;
        RowClick.SetMyColor(new Color32(255, 255, 255, 255));
        ColumnClick.SetMyColor(new Color32(255, 255, 255, 255));
        SceneManager.LoadScene("Mainmenu");
    }
    public void LoadLevel1()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        PlayerPrefs.SetInt("Levels", 1);
        SceneManager.LoadScene("Game");
    }
    public void LoadLevel2()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        PlayerPrefs.SetInt("Levels", 2);
        SceneManager.LoadScene("Game");
    }
    public void LoadLevel3()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        PlayerPrefs.SetInt("Levels", 3);
        SceneManager.LoadScene("Game");
    }
    public void LoadLevel4()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        PlayerPrefs.SetInt("Levels", 4);
        SceneManager.LoadScene("Game");
    }
    public void LoadLevel5()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        PlayerPrefs.SetInt("Levels", 5);
        SceneManager.LoadScene("Game");
    }
    public void LoadLevel6()
    {
        FindObjectOfType<AudioManager>().Play("Touch");
        PlayerPrefs.SetInt("Levels", 6);
        SceneManager.LoadScene("Game");
    }
}
