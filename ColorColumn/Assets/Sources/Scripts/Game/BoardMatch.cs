using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum colorboard
{
    blank,
    red,
    green,
    blue,
    orange,
    purple
}

public class BoardMatch : MonoBehaviour
{
    GameObject[] firstColumn;
    GameObject[] secondColumn;
    GameObject[] thirdColumn;
    GameObject[] fourthColumn;
    GameObject[] fifthColumn;

    public GameObject tutorialTarget, level1Target, level2Target, level3Target, level4Target, level5Target, level6Target, level7Target;
    public GameObject clearPanel, failPanel, pauseEffect;

    int levelCount;
    public static int clickCount = 0;

    Color32 redPal = new Color32(255, 0, 0, 255);
    Color32 greenPal = new Color32(0, 200, 0, 255);
    Color32 bluePal = new Color32(0, 0, 230, 255);
    Color32 orangePal = new Color32(255, 120, 0, 255);
    Color32 purplePal = new Color32(200, 30, 190, 255);
    int[] A = { 0, 0, 0, 0, 0 };
    int[] B = { 0, 0, 0, 0, 0 };
    int[] C = { 0, 0, 0, 0, 0 };
    int[] D = { 0, 0, 0, 0, 0 };
    int[] E = { 0, 0, 0, 0, 0 };

    //Tutorial target / 5
    int[] tutorialA = { (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue };
    int[] tutorialB = { (int)colorboard.red, (int)colorboard.red, (int)colorboard.red, (int)colorboard.red, (int)colorboard.red };
    int[] tutorialC = { (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue };
    int[] tutorialD = { (int)colorboard.red, (int)colorboard.red, (int)colorboard.red, (int)colorboard.red, (int)colorboard.red };
    int[] tutorialE = { (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue };

    //Level1 target / 9
    int[] level1A = { (int)colorboard.green, (int)colorboard.green, (int)colorboard.green, (int)colorboard.green, (int)colorboard.green };
    int[] level1B = { (int)colorboard.red, (int)colorboard.red, (int)colorboard.red, (int)colorboard.red, (int)colorboard.green };
    int[] level1C = { (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.red, (int)colorboard.green };
    int[] level1D = { (int)colorboard.blue, (int)colorboard.green, (int)colorboard.green, (int)colorboard.red, (int)colorboard.green };
    int[] level1E = { (int)colorboard.blue, (int)colorboard.green, (int)colorboard.red, (int)colorboard.red, (int)colorboard.green };

    //Level2 target / 7
    int[] level2A = { (int)colorboard.red, (int)colorboard.green, (int)colorboard.red, (int)colorboard.green, (int)colorboard.red };
    int[] level2B = { (int)colorboard.red, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.red };
    int[] level2C = { (int)colorboard.red, (int)colorboard.green, (int)colorboard.red, (int)colorboard.green, (int)colorboard.red };
    int[] level2D = { (int)colorboard.red, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.red };
    int[] level2E = { (int)colorboard.red, (int)colorboard.green, (int)colorboard.red, (int)colorboard.green, (int)colorboard.red };

    //Level3 target / 9
    int[] level3A = { (int)colorboard.blue, (int)colorboard.red, (int)colorboard.red, (int)colorboard.red, (int)colorboard.green };
    int[] level3B = { (int)colorboard.blue, (int)colorboard.green, (int)colorboard.green, (int)colorboard.blue, (int)colorboard.green };
    int[] level3C = { (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.red, (int)colorboard.blue, (int)colorboard.green };
    int[] level3D = { (int)colorboard.blue, (int)colorboard.green, (int)colorboard.green, (int)colorboard.blue, (int)colorboard.green };
    int[] level3E = { (int)colorboard.blue, (int)colorboard.red, (int)colorboard.red, (int)colorboard.red, (int)colorboard.green };

    //Level4 target / 9
    int[] level4A = { (int)colorboard.green, (int)colorboard.green, (int)colorboard.green, (int)colorboard.green, (int)colorboard.green };
    int[] level4B = { (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue };
    int[] level4C = { (int)colorboard.orange, (int)colorboard.purple, (int)colorboard.red, (int)colorboard.green, (int)colorboard.blue };
    int[] level4D = { (int)colorboard.green, (int)colorboard.green, (int)colorboard.green, (int)colorboard.green, (int)colorboard.green };
    int[] level4E = { (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue, (int)colorboard.blue };

    //Level5 target / 11
    int[] level5A = { (int)colorboard.orange, (int)colorboard.purple, (int)colorboard.green, (int)colorboard.orange, (int)colorboard.purple };
    int[] level5B = { (int)colorboard.red, (int)colorboard.purple, (int)colorboard.red, (int)colorboard.orange, (int)colorboard.red };
    int[] level5C = { (int)colorboard.blue, (int)colorboard.purple, (int)colorboard.blue, (int)colorboard.orange, (int)colorboard.blue };
    int[] level5D = { (int)colorboard.red, (int)colorboard.purple, (int)colorboard.red, (int)colorboard.orange, (int)colorboard.red };
    int[] level5E = { (int)colorboard.purple, (int)colorboard.purple, (int)colorboard.green, (int)colorboard.orange, (int)colorboard.purple };
    
    //Level6 target / 8
    int[] level6A = { (int)colorboard.blank, (int)colorboard.purple, (int)colorboard.blue, (int)colorboard.green, (int)colorboard.orange };
    int[] level6B = { (int)colorboard.orange, (int)colorboard.purple, (int)colorboard.orange, (int)colorboard.orange, (int)colorboard.orange };
    int[] level6C = { (int)colorboard.red, (int)colorboard.purple, (int)colorboard.blue, (int)colorboard.red, (int)colorboard.red };
    int[] level6D = { (int)colorboard.purple, (int)colorboard.purple, (int)colorboard.blue, (int)colorboard.green, (int)colorboard.purple };
    int[] level6E = { (int)colorboard.blue, (int)colorboard.purple, (int)colorboard.blue, (int)colorboard.green, (int)colorboard.orange };

    //Level7 target / 15
    int[] level7A = { (int)colorboard.green, (int)colorboard.green, (int)colorboard.blue, (int)colorboard.orange, (int)colorboard.green };
    int[] level7B = { (int)colorboard.orange, (int)colorboard.orange, (int)colorboard.orange, (int)colorboard.orange, (int)colorboard.orange };
    int[] level7C = { (int)colorboard.blue, (int)colorboard.purple, (int)colorboard.blue, (int)colorboard.orange, (int)colorboard.red };
    int[] level7D = { (int)colorboard.orange, (int)colorboard.orange, (int)colorboard.orange, (int)colorboard.orange, (int)colorboard.orange };
    int[] level7E = { (int)colorboard.green, (int)colorboard.green, (int)colorboard.blue, (int)colorboard.orange, (int)colorboard.green };

    private void Awake()
    {
        firstColumn = GameObject.FindGameObjectsWithTag("ColumnA");
        secondColumn = GameObject.FindGameObjectsWithTag("ColumnB");
        thirdColumn = GameObject.FindGameObjectsWithTag("ColumnC");
        fourthColumn = GameObject.FindGameObjectsWithTag("ColumnD");
        fifthColumn = GameObject.FindGameObjectsWithTag("ColumnE");

        clickCount = 0;
        levelCount = PlayerPrefs.GetInt("Levels");
    }
    void CheckMatch()
    {
        for (int i = 0; i < 5; i++)
        {
            switch (firstColumn[i].name)
            {
                case "A1":
                    if (firstColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        A[0] = 1;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        A[0] = 2;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        A[0] = 3;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        A[0] = 4;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        A[0] = 5;
                    break;

                case "A2":
                    if (firstColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        A[1] = 1;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        A[1] = 2;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        A[1] = 3;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        A[1] = 4;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        A[1] = 5;
                    break;

                case "A3":
                    if (firstColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        A[2] = 1;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        A[2] = 2;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        A[2] = 3;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        A[2] = 4;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        A[2] = 5;
                    break;

                case "A4":
                    if (firstColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        A[3] = 1;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        A[3] = 2;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        A[3] = 3;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        A[3] = 4;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        A[3] = 5;
                    break;

                case "A5":
                    if (firstColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        A[4] = 1;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        A[4] = 2;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        A[4] = 3;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        A[4] = 4;
                    else if (firstColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        A[4] = 5;
                    break;

                default:
                    return;
            }
            switch (secondColumn[i].name)
            {
                case "B1":
                    if (secondColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        B[0] = 1;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        B[0] = 2;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        B[0] = 3;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        B[0] = 4;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        B[0] = 5;
                    break;

                case "B2":
                    if (secondColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        B[1] = 1;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        B[1] = 2;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        B[1] = 3;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        B[1] = 4;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        B[1] = 5;
                    break;

                case "B3":
                    if (secondColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        B[2] = 1;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        B[2] = 2;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        B[2] = 3;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        B[2] = 4;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        B[2] = 5;
                    break;

                case "B4":
                    if (secondColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        B[3] = 1;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        B[3] = 2;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        B[3] = 3;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        B[3] = 4;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        B[3] = 5;
                    break;

                case "B5":
                    if (secondColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        B[4] = 1;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        B[4] = 2;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        B[4] = 3;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        B[4] = 4;
                    else if (secondColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        B[4] = 5;
                    break;

                default:
                    return;
            }
            switch (thirdColumn[i].name)
            {
                case "C1":
                    if (thirdColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        C[0] = 1;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        C[0] = 2;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        C[0] = 3;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        C[0] = 4;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        C[0] = 5;
                    break;

                case "C2":
                    if (thirdColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        C[1] = 1;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        C[1] = 2;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        C[1] = 3;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        C[1] = 4;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        C[1] = 5;
                    break;

                case "C3":
                    if (thirdColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        C[2] = 1;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        C[2] = 2;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        C[2] = 3;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        C[2] = 4;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        C[2] = 5;
                    break;

                case "C4":
                    if (thirdColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        C[3] = 1;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        C[3] = 2;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        C[3] = 3;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        C[3] = 4;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        C[3] = 5;
                    break;

                case "C5":
                    if (thirdColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        C[4] = 1;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        C[4] = 2;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        C[4] = 3;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        C[4] = 4;
                    else if (thirdColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        C[4] = 5;
                    break;

                default:
                    return;
            }
            switch (fourthColumn[i].name)
            {
                case "D1":
                    if (fourthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        D[0] = 1;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        D[0] = 2;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        D[0] = 3;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        D[0] = 4;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        D[0] = 5;
                    break;

                case "D2":
                    if (fourthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        D[1] = 1;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        D[1] = 2;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        D[1] = 3;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        D[1] = 4;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        D[1] = 5;
                    break;

                case "D3":
                    if (fourthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        D[2] = 1;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        D[2] = 2;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        D[2] = 3;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        D[2] = 4;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        D[2] = 5;
                    break;

                case "D4":
                    if (fourthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        D[3] = 1;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        D[3] = 2;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        D[3] = 3;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        D[3] = 4;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        D[3] = 5;
                    break;

                case "D5":
                    if (fourthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        D[4] = 1;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        D[4] = 2;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        D[4] = 3;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        D[4] = 4;
                    else if (fourthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        D[4] = 5;
                    break;

                default:
                    return;
            }
            switch (fifthColumn[i].name)
            {
                case "E1":
                    if (fifthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        E[0] = 1;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        E[0] = 2;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        E[0] = 3;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        E[0] = 4;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        E[0] = 5;
                    break;

                case "E2":
                    if (fifthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        E[1] = 1;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        E[1] = 2;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        E[1] = 3;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        E[1] = 4;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        E[1] = 5;
                    break;

                case "E3":
                    if (fifthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        E[2] = 1;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        E[2] = 2;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        E[2] = 3;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        E[2] = 4;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        E[2] = 5;
                    break;

                case "E4":
                    if (fifthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        E[3] = 1;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        E[3] = 2;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        E[3] = 3;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        E[3] = 4;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        E[3] = 5;
                    break;

                case "E5":
                    if (fifthColumn[i].GetComponent<SpriteRenderer>().color == redPal)
                        E[4] = 1;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == greenPal)
                        E[4] = 2;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == bluePal)
                        E[4] = 3;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == orangePal)
                        E[4] = 4;
                    else if (fifthColumn[i].GetComponent<SpriteRenderer>().color == purplePal)
                        E[4] = 5;
                    break;

                default:
                    return;
            }
        }
    }

    bool TutorialMatchDecision()
    {
        if (   A[0] == tutorialA[0] && A[1] == tutorialA[1] && A[2] == tutorialA[2]
            && A[3] == tutorialA[3] && A[4] == tutorialA[4] && B[0] == tutorialB[0]
            && B[1] == tutorialB[1] && B[2] == tutorialB[2] && B[3] == tutorialB[3]
            && B[4] == tutorialB[4] && C[0] == tutorialC[0] && C[1] == tutorialC[1]
            && C[2] == tutorialC[2] && C[3] == tutorialC[3] && C[4] == tutorialC[4]
            && D[0] == tutorialD[0] && D[1] == tutorialD[1] && D[2] == tutorialD[2]
            && D[3] == tutorialD[3] && D[4] == tutorialD[4] && E[0] == tutorialE[0]
            && E[1] == tutorialE[1] && E[2] == tutorialE[2] && E[3] == tutorialE[3]
            && E[4] == tutorialE[4])
        {
            return true;
        }
        return false;
    }
    bool Level1MatchDecision()
    {
        if (   A[0] == level1A[0] && A[1] == level1A[1] && A[2] == level1A[2]
            && A[3] == level1A[3] && A[4] == level1A[4] && B[0] == level1B[0]
            && B[1] == level1B[1] && B[2] == level1B[2] && B[3] == level1B[3]
            && B[4] == level1B[4] && C[0] == level1C[0] && C[1] == level1C[1]
            && C[2] == level1C[2] && C[3] == level1C[3] && C[4] == level1C[4]
            && D[0] == level1D[0] && D[1] == level1D[1] && D[2] == level1D[2]
            && D[3] == level1D[3] && D[4] == level1D[4] && E[0] == level1E[0]
            && E[1] == level1E[1] && E[2] == level1E[2] && E[3] == level1E[3]
            && E[4] == level1E[4])
        {
            return true;
        }
        return false;
    }

    bool Level2MatchDecision()
    {
        if (   A[0] == level2A[0] && A[1] == level2A[1] && A[2] == level2A[2]
            && A[3] == level2A[3] && A[4] == level2A[4] && B[0] == level2B[0]
            && B[1] == level2B[1] && B[2] == level2B[2] && B[3] == level2B[3]
            && B[4] == level2B[4] && C[0] == level2C[0] && C[1] == level2C[1]
            && C[2] == level2C[2] && C[3] == level2C[3] && C[4] == level2C[4]
            && D[0] == level2D[0] && D[1] == level2D[1] && D[2] == level2D[2]
            && D[3] == level2D[3] && D[4] == level2D[4] && E[0] == level2E[0]
            && E[1] == level2E[1] && E[2] == level2E[2] && E[3] == level2E[3]
            && E[4] == level2E[4])
        {
            return true;
        }
        return false;
    }

    bool Level3MatchDecision()
    {
        if (   A[0] == level3A[0] && A[1] == level3A[1] && A[2] == level3A[2]
            && A[3] == level3A[3] && A[4] == level3A[4] && B[0] == level3B[0]
            && B[1] == level3B[1] && B[2] == level3B[2] && B[3] == level3B[3]
            && B[4] == level3B[4] && C[0] == level3C[0] && C[1] == level3C[1]
            && C[2] == level3C[2] && C[3] == level3C[3] && C[4] == level3C[4]
            && D[0] == level3D[0] && D[1] == level3D[1] && D[2] == level3D[2]
            && D[3] == level3D[3] && D[4] == level3D[4] && E[0] == level3E[0]
            && E[1] == level3E[1] && E[2] == level3E[2] && E[3] == level3E[3]
            && E[4] == level3E[4])
        {
            return true;
        }
        return false;
    }

    bool Level4MatchDecision()
    {
        if (   A[0] == level4A[0] && A[1] == level4A[1] && A[2] == level4A[2]
            && A[3] == level4A[3] && A[4] == level4A[4] && B[0] == level4B[0]
            && B[1] == level4B[1] && B[2] == level4B[2] && B[3] == level4B[3]
            && B[4] == level4B[4] && C[0] == level4C[0] && C[1] == level4C[1]
            && C[2] == level4C[2] && C[3] == level4C[3] && C[4] == level4C[4]
            && D[0] == level4D[0] && D[1] == level4D[1] && D[2] == level4D[2]
            && D[3] == level4D[3] && D[4] == level4D[4] && E[0] == level4E[0]
            && E[1] == level4E[1] && E[2] == level4E[2] && E[3] == level4E[3]
            && E[4] == level4E[4])
        {
            return true;
        }
        return false;
    }
    bool Level5MatchDecision()
    {
        if (   A[0] == level5A[0] && A[1] == level5A[1] && A[2] == level5A[2]
            && A[3] == level5A[3] && A[4] == level5A[4] && B[0] == level5B[0]
            && B[1] == level5B[1] && B[2] == level5B[2] && B[3] == level5B[3]
            && B[4] == level5B[4] && C[0] == level5C[0] && C[1] == level5C[1]
            && C[2] == level5C[2] && C[3] == level5C[3] && C[4] == level5C[4]
            && D[0] == level5D[0] && D[1] == level5D[1] && D[2] == level5D[2]
            && D[3] == level5D[3] && D[4] == level5D[4] && E[0] == level5E[0]
            && E[1] == level5E[1] && E[2] == level5E[2] && E[3] == level5E[3]
            && E[4] == level5E[4])
        {
            return true;
        }
        return false;
    }
    bool Level6MatchDecision()
    {
        if (   A[0] == level6A[0] && A[1] == level6A[1] && A[2] == level6A[2]
            && A[3] == level6A[3] && A[4] == level6A[4] && B[0] == level6B[0]
            && B[1] == level6B[1] && B[2] == level6B[2] && B[3] == level6B[3]
            && B[4] == level6B[4] && C[0] == level6C[0] && C[1] == level6C[1]
            && C[2] == level6C[2] && C[3] == level6C[3] && C[4] == level6C[4]
            && D[0] == level6D[0] && D[1] == level6D[1] && D[2] == level6D[2]
            && D[3] == level6D[3] && D[4] == level6D[4] && E[0] == level6E[0]
            && E[1] == level6E[1] && E[2] == level6E[2] && E[3] == level6E[3]
            && E[4] == level6E[4])
        {
            return true;
        }
        return false;
    }
    bool Level7MatchDecision()
    {
        if (   A[0] == level7A[0] && A[1] == level7A[1] && A[2] == level7A[2]
            && A[3] == level7A[3] && A[4] == level7A[4] && B[0] == level7B[0]
            && B[1] == level7B[1] && B[2] == level7B[2] && B[3] == level7B[3]
            && B[4] == level7B[4] && C[0] == level7C[0] && C[1] == level7C[1]
            && C[2] == level7C[2] && C[3] == level7C[3] && C[4] == level7C[4]
            && D[0] == level7D[0] && D[1] == level7D[1] && D[2] == level7D[2]
            && D[3] == level7D[3] && D[4] == level7D[4] && E[0] == level7E[0]
            && E[1] == level7E[1] && E[2] == level7E[2] && E[3] == level7E[3]
            && E[4] == level7E[4])
        {
            return true;
        }
        return false;
    }

    private void Update()
    {
        CheckMatch();
        LevelCheck();
    }

    void LevelCheck()
    {
        switch(levelCount)
        {
            case 0:
                tutorialTarget.SetActive(true);
                if (TutorialMatchDecision())
                {
                    tutorialTarget.SetActive(false);
                    Debug.Log("Clear");
                    levelCount = 1;
                    PlayerPrefs.SetInt("Levels", levelCount);
                    pauseEffect.SetActive(true);
                    clearPanel.SetActive(true);
                }
                break;
            case 1:
                if (clickCount <= 9)
                {
                    level1Target.SetActive(true);
                    if (Level1MatchDecision())
                    {
                        clickCount = 0;
                        level1Target.SetActive(false);
                        Debug.Log("Clear");
                        levelCount = 2;
                        PlayerPrefs.SetInt("Levels", levelCount);
                        pauseEffect.SetActive(true);
                        clearPanel.SetActive(true);
                    }
                }
                else if (clickCount >= 9)
                {
                    clickCount = 0;
                    pauseEffect.SetActive(true);
                    failPanel.SetActive(true);
                }
                break;
            case 2:
                if (clickCount <= 7)
                {
                    level2Target.SetActive(true);
                    if (Level2MatchDecision())
                    {
                        clickCount = 0;
                        level2Target.SetActive(false);
                        Debug.Log("Clear");
                        levelCount = 3;
                        PlayerPrefs.SetInt("Levels", levelCount);
                        pauseEffect.SetActive(true);
                        clearPanel.SetActive(true);
                    }
                }
                else if (clickCount >= 7)
                {
                    clickCount = 0;
                    pauseEffect.SetActive(true);
                    failPanel.SetActive(true);
                }
                break;
            case 3:
                if (clickCount <= 9)
                {
                    level3Target.SetActive(true);
                    if (Level3MatchDecision())
                    {
                        clickCount = 0;
                        level3Target.SetActive(false);
                        Debug.Log("Clear");
                        levelCount = 4;
                        PlayerPrefs.SetInt("Levels", levelCount);
                        pauseEffect.SetActive(true);
                        clearPanel.SetActive(true);
                    }
                }
                else if (clickCount >= 9)
                {
                    clickCount = 0;
                    pauseEffect.SetActive(true);
                    failPanel.SetActive(true);
                }
                break;
            case 4:
                if (clickCount <= 9)
                {
                    clickCount = 0;
                    level4Target.SetActive(true);
                    if (Level4MatchDecision())
                    {
                        level4Target.SetActive(false);
                        Debug.Log("Clear");
                        levelCount = 5;
                        PlayerPrefs.SetInt("Levels", levelCount);
                        pauseEffect.SetActive(true);
                        clearPanel.SetActive(true);
                    }
                }
                else if (clickCount >= 9)
                {
                    clickCount = 0;
                    pauseEffect.SetActive(true);
                    failPanel.SetActive(true);
                }
                break;
            case 5:
                if (clickCount <= 11)
                {
                    level5Target.SetActive(true);
                    if (Level5MatchDecision())
                    {
                        clickCount = 0;
                        level5Target.SetActive(false);
                        Debug.Log("Clear");
                        levelCount = 6;
                        PlayerPrefs.SetInt("Levels", levelCount);
                        pauseEffect.SetActive(true);
                        clearPanel.SetActive(true);
                    }
                }
                else if (clickCount >= 11)
                {
                    clickCount = 0;
                    pauseEffect.SetActive(true);
                    failPanel.SetActive(true);
                }
                break;
            case 6:
                if (clickCount <= 8)
                {
                    level6Target.SetActive(true);
                    if (Level6MatchDecision())
                    {
                        clickCount = 0;
                        level6Target.SetActive(false);
                        Debug.Log("Clear");
                        levelCount = 7;
                        PlayerPrefs.SetInt("Levels", levelCount);
                        pauseEffect.SetActive(true);
                        clearPanel.SetActive(true);
                    }
                }
                else if (clickCount >= 8)
                {
                    clickCount = 0;
                    pauseEffect.SetActive(true);
                    failPanel.SetActive(true);
                }
                break;
            case 7:
                if (clickCount <= 15)
                {
                    level7Target.SetActive(true);
                    if (Level7MatchDecision())
                    {
                        clickCount = 0;
                        level7Target.SetActive(false);
                        Debug.Log("Clear");
                        levelCount = 8;
                        PlayerPrefs.SetInt("Levels", levelCount);
                        pauseEffect.SetActive(true);
                        clearPanel.SetActive(true);
                    }
                }
                else if (clickCount >= 15)
                {
                    clickCount = 0;
                    pauseEffect.SetActive(true);
                    failPanel.SetActive(true);
                }
                break;
            default:

                break;
        }
    }
}
