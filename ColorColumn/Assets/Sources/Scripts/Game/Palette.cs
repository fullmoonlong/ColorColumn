using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palette : MonoBehaviour
{
    Color32 Red    = new Color32(255, 0, 0, 255);
    Color32 Green  = new Color32(0, 200, 0, 255);
    Color32 Blue   = new Color32(0, 0, 230, 255);
    Color32 Orange = new Color32(255, 120, 0, 255);
    Color32 Purple = new Color32(200, 30, 190, 255);

    public void RedPaletteClick()
    {
        FindObjectOfType<AudioManager>().Play("Palette");
        RowClick.SetMyColor(Red);
        ColumnClick.SetMyColor(Red);
    }
    public void GreenPaletteClick()
    {
        FindObjectOfType<AudioManager>().Play("Palette");
        RowClick.SetMyColor(Green);
        ColumnClick.SetMyColor(Green);
    }
    public void BluePaletteClick()
    {
        FindObjectOfType<AudioManager>().Play("Palette");
        RowClick.SetMyColor(Blue);
        ColumnClick.SetMyColor(Blue);
    }
    public void OrangePaletteClick()
    {
        FindObjectOfType<AudioManager>().Play("Palette");
        RowClick.SetMyColor(Orange);
        ColumnClick.SetMyColor(Orange);
    }
    public void PurplePaletteClick()
    {
        FindObjectOfType<AudioManager>().Play("Palette");
        RowClick.SetMyColor(Purple);
        ColumnClick.SetMyColor(Purple);
    }
}
