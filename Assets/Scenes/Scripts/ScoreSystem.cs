using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static int Score = 0;

    Text score;

    void Start()
    { 
        score = GetComponent<Text> ();
    }

    void Update()
    {
        score.text = "Score:" + Score;
    }
}
