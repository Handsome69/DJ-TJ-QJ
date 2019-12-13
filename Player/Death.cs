using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private Transform startPos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = startPos.position;
    }
}
