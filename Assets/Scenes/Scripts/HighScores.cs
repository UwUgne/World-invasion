using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    Text HighScore;
   
    void Start()
    {
        HighScore = GetComponent<Text>();
    }

   
    void Update()
    {
        HighScore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore");
    }
}
