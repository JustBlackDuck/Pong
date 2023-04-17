using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 2f;
    public Vector2 direction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            direction = Vector2.up; //Вектор new Vector(0,1)
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            direction = Vector2.down;
        }
        else {
            direction = Vector2.zero; //Если никуда не движемся
        }
        if(direction.x*direction.x + direction.y*direction.y != 0) {
            rb.AddForce(direction*speed);
        }
    }
}
