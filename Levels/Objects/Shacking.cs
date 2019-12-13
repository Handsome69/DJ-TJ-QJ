using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shacking : MonoBehaviour
{
    public Rigidbody2D rb;
    public float sr;
    public float sx;
    public float sy;
    int fullF;
    int frame;
    bool bom;
    int i;
    bool bom2;
    int i2;
    void Update()
    {
        transform.Rotate(0, 0, sr);
        fullF++;
        frame++;
        rb.velocity = new Vector2(sx * i2, sy * i2 * -1);
        if(frame > 10)
        {
            sr *= 1.2f * i;
            frame = 0;
            bom2= !bom2;
            if (bom2)
                i2 = 1;
            else
                i2 = -1;
        }
        if(fullF > 30)
        {
            bom = !bom;
            if (bom)
                i = 1;
            else
                i = -1;
            fullF = 0;
            sr = 7 * i;
        }
    }
}
