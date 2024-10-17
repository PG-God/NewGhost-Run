using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jamp : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-25, 0, 0); //左に「25」動かす
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(25, 0, 0); //右に「25」動かす
        }
    }
}
