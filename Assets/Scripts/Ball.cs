using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 40f;
    Rigidbody2D rb;
    Vector2 direction;
    public GameManager manager;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        AddStartingForce();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = direction * speed;
    }

    public void AddStartingForce()
    {
        direction = new Vector2(Random.Range(-0.5f, -1f), Random.Range(-0.5f, -1f));
    }

    public void ResetPosition() {
        rb.velocity = Vector2.zero;
        rb.position = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Player") {
            direction.x = -direction.x;
        }

        if(collision.gameObject.tag == "Computer") {
            direction.x = -direction.x;
        }

        if(collision.gameObject.tag == "TopDownWall") {
            direction.y = -direction.y;
        }

        if(collision.gameObject.tag == "SideWall") {
    
            manager.StartRound();
        }

    }
}
