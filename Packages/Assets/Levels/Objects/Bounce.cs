using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float speed;
    public Transform positionDir;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.Rotate(0, 0, 180);
    }

    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, positionDir.position, speed);
    }

}
