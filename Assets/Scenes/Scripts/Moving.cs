using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float Speed = 2.5f;
    public GameObject character;
    public Rigidbody2D rb;
    private float screenWidth;


    void Start()
    {
        screenWidth = Screen.width;
        rb = character.GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        int i = 0;
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > screenWidth / 2)
            {
                MoveCharacter(1.0f);
            }

            else if (Input.GetTouch(i).position.x < screenWidth / 2)
            {
                MoveCharacter(-1.0f);
            }
            i++;
        }
    }

    private void MoveCharacter(float horizontal)
    {
        rb.transform.Translate(new Vector2(horizontal * Speed * Time.deltaTime, 0));
    }
}
