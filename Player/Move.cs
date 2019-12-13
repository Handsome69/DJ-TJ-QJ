using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float EX;
    public float EY;
    public Breaking b;
    public float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(b.LevelCompleted)
        {
            transform.position = new Vector2(EX, EY);
        }
        rb.velocity = new Vector2(speed * Input.GetAxis("Horizontal"), rb.velocity.y);
    }
}
