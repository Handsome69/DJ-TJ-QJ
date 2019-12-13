using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Breaking : MonoBehaviour
{
    public string sceneName;
    public bool LevelCompleted = false;
    bool isCol;
    public Transform ColCheck;
    public float Radius;
    public LayerMask Player;

    void Update()
    {
        isCol = Physics2D.OverlapCircle(ColCheck.position, Radius, Player);
        if(isCol)
        {
            LevelCompleted = true;
            transform.localScale = new Vector3(transform.localScale.x + 1, transform.localScale.y + 1, transform.localScale.z + 1);
        }
        if(transform.localScale.x > 45)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
