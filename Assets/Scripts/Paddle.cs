using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    public void ResetPosition()
    {
        rb.velocity = Vector2.zero; //Сбрасываем скорость на ноль
        rb.position = new Vector2(rb.position.x, 0f); //Меняем скорость по y
    }

    void Update()
    {
        
    }
}
