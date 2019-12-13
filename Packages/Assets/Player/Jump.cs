using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    public Text count;
    bool isGround;
    public Transform groundCheck;
    public float Radius;
    public LayerMask Ground;
    Rigidbody2D rb;
    public float Power;
    private int exJump;
    public int maxJump;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isGround)
            exJump = maxJump - 1;
        isGround = Physics2D.OverlapCircle(groundCheck.position, Radius, Ground);
        if(Input.GetKeyUp(KeyCode.Space) && exJump > 0)
        {
            rb.velocity = Vector2.zero;
            rb.velocity = new Vector2(rb.velocity.x, Power);
            exJump--;
        }
        count.text = exJump + "";
    }
}
