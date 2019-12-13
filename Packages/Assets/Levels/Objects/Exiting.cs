using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exiting : MonoBehaviour
{
    void Update()
    {
        if(transform.localScale.x < 0)
        {
            Destroy(gameObject);
        }
        transform.localScale = new Vector3(transform.localScale.x - 1, transform.localScale.y - 1, transform.localScale.z - 1);
    }
}
