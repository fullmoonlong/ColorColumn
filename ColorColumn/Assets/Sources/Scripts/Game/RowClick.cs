using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RowClick : MonoBehaviour
{
    GameObject firstRow, secondRow, thirdRow, fourthRow, fifthRow;
    public GameObject button;
    public static Color32 myColor = new Color32(255, 255, 255, 255);
    private void Awake()
    {
        firstRow = GameObject.Find("RowButton1");
        secondRow = GameObject.Find("RowButton2");
        thirdRow = GameObject.Find("RowButton3");
        fourthRow = GameObject.Find("RowButton4");
        fifthRow = GameObject.Find("RowButton5");
    }

    public static void SetMyColor(Color32 setColor)
    {
        myColor = setColor;
    }

    private void onRow1Click()
    {
        int i = 1;
        RaycastHit2D[] firstRowrayhit = Physics2D.RaycastAll(firstRow.transform.position, Vector3.right);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (firstRowrayhit[i].collider != null)
                {
                    firstRowrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
                    i++;
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
        }
    }
    private void onRow2Click()
    {
        int i = 1;
        RaycastHit2D[] secondRowrayhit = Physics2D.RaycastAll(secondRow.transform.position, Vector3.right);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (secondRowrayhit[i].collider != null)
                {
                    secondRowrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
                    i++;
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
        }
    }
    private void onRow3Click()
    {
        int i = 1;
        RaycastHit2D[] thirdRowrayhit = Physics2D.RaycastAll(thirdRow.transform.position, Vector3.right);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (thirdRowrayhit[i].collider != null)
                {
                    thirdRowrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
                    i++;
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
        }
    }
    private void onRow4Click()
    {
        int i = 1;
        RaycastHit2D[] fourthRowrayhit = Physics2D.RaycastAll(fourthRow.transform.position, Vector3.right);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (fourthRowrayhit[i].collider != null)
                {
                    fourthRowrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
                    i++;
                    if (i == 6)
                    {
                        break;
                    }
                }
            }
        }
    }
    private void onRow5Click()
    {
        int i = 1;
        RaycastHit2D[] fifthRowrayhit = Physics2D.RaycastAll(fifthRow.transform.position, Vector3.right);
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                FindObjectOfType<AudioManager>().Play("BrushLine");
                BoardMatch.clickCount++;
                while (fifthRowrayhit[i].collider != null)
                {
                    fifthRowrayhit[i].transform.GetComponent<SpriteRenderer>().color = myColor;
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
        if (button == GameObject.Find("RowButton1"))
        {
            onRow1Click();
        }
        else if (button == GameObject.Find("RowButton2"))
        {
            onRow2Click();
        }
        else if (button == GameObject.Find("RowButton3"))
        {
            onRow3Click();
        }
        else if (button == GameObject.Find("RowButton4"))
        {
            onRow4Click();
        }
        else if (button == GameObject.Find("RowButton5"))
        {
            onRow5Click();
        }
    }


}
