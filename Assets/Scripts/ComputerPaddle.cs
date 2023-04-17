using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : MonoBehaviour
{
    public Rigidbody2D ball;
    public float speed = 8f;
    Rigidbody2D rb;

private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    

 private void Update()
    {
        if(ball.velocity.x > 0f)
        {
            
            if(ball.position.y > rb.position.y) {
                rb.AddForce(Vector2.up*speed);
            } else if (ball.position.y < rb.position.y) {
                rb.AddForce(Vector2.down *speed);
            }
        }

else {
        if(rb.position.y > 0f)
        {
            
                rb.AddForce(Vector2.down*speed);
        }
            else if (rb.position.y < 0f) {
                rb.AddForce(Vector2.up *speed);
            }
        }
}
}
    
