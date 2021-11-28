using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lastScore : MonoBehaviour
{
    public Text text;
    public static int scorepoints=0;
    
    // Start is called before the first frame update
    void Start()
    {
        scorepoints = score.scorepoints;
        text.text = "Score : " + scorepoints.ToString("0");
    }



}
