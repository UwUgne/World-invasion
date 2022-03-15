using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuButton : MonoBehaviour
{
    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
                return;
            }
        }
    }
}
