using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmemyScript : MonoBehaviour
{

    public float speed = 1f;

    void Update()
    {
        transform.position += new Vector3(0, -speed * Time.deltaTime, 0); 

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            ScoreSystem.Score += 1;
        }

        
        if (collision.gameObject.tag == "Target")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Death");
        }
        
    }
}

