using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullets : MonoBehaviour
{
    public float Time = 2.2f;

    void Start()
    {
        Destroy(gameObject, Time);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Alien")
        {
            Destroy(gameObject);
        }
    }
}
