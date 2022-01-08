using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    void Start()
    {
        if (ScoreSystem.Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", ScoreSystem.Score);
        }
    }

    public void Restart ()
    {
        if (ScoreSystem.Score > PlayerPrefs.GetInt("HighScore") )
        {
            PlayerPrefs.SetInt("HighScore", ScoreSystem.Score);
        }

        ScoreSystem.Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void MainMenu()
    {
        if (ScoreSystem.Score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", ScoreSystem.Score);
        }

        ScoreSystem.Score = 0;
        SceneManager.LoadScene("MenuScene");
    }
}
