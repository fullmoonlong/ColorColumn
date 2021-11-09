using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Director : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(BoardMatch.clickCount);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            Reload();
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
