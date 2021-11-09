using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColumnClick : MonoBehaviour
{
    GameObject firstColumn, secondColumn, thirdColumn, fourthColumn, fifthColumn;
    public GameObject button;
    public static Color32 myColor = new Color32(255, 255, 255, 255);

    private void Awake()
    {
        firstColumn = GameObject.Find("ColumnButton1");
        secondColumn = GameObject.Find("ColumnButton2");
        thirdColumn = GameObject.Find("ColumnButton3");
        fourthColumn = GameObject.Find("ColumnButton4");
        fifthColumn = GameObject.Find("ColumnButton5");
    }

    public static void SetMyColor(Color32 setColor)
    {
        myColor = setColor;
    }

    private void onColumn1Click()
    {
        int i = 1;
        RaycastHit2D[] firstColumnrayhit = Physics2D.RaycastAll(firstColumn.transform.position, Vector3.down);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (firstColumnrayhit[i].collider != null)
                {
                    firstColumnrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
                    i++;
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
        }
    }
    private void onColumn2Click()
    {
        int i = 1;
        RaycastHit2D[] secondColumnrayhit = Physics2D.RaycastAll(secondColumn.transform.position, Vector3.down);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (secondColumnrayhit[i].collider != null)
                {
                    secondColumnrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
                    i++;
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
        }
    }
    private void onColumn3Click()
    {
        int i = 1;
        RaycastHit2D[] thirdColumnrayhit = Physics2D.RaycastAll(thirdColumn.transform.position, Vector3.down);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (thirdColumnrayhit[i].collider != null)
                {
                    thirdColumnrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
                    i++;
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
        }
    }
    private void onColumn4Click()
    {
        int i = 1;
        RaycastHit2D[] fourthColumnrayhit = Physics2D.RaycastAll(fourthColumn.transform.position, Vector3.down);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (fourthColumnrayhit[i].collider != null)
                {
                    fourthColumnrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
                    i++;
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
        }
    }
    private void onColumn5Click()
    {
        int i = 1;
        RaycastHit2D[] fifthColumnrayhit = Physics2D.RaycastAll(fifthColumn.transform.position, Vector3.down);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (fifthColumnrayhit[i].collider != null)
                {
                    fifthColumnrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
                    i++;
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
        }
    }
    private void OnMouseOver()
    {
        if (button == GameObject.Find("ColumnButton1"))
        {
            onColumn1Click();
        }
        else if (button == GameObject.Find("ColumnButton2"))
        {
            onColumn2Click();
        }
        else if (button == GameObject.Find("ColumnButton3"))
        {
            onColumn3Click();
        }
        else if (button == GameObject.Find("ColumnButton4"))
        {
            onColumn4Click();
        }
        else if (button == GameObject.Find("ColumnButton5"))
        {
            onColumn5Click();
        }
    }


}
