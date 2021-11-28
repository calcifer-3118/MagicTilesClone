using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text text;
    public static int scorepoints;
    public int scoree = 0;

    public void scoreUpdate(int score)
    {

        scoree += score;
        scorepoints += score;
        text.text = scorepoints.ToString("0");
    }
}
