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
            transform.Translate(-25, 0, 0); //���Ɂu25�v������
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(25, 0, 0); //�E�Ɂu25�v������
        }
    }
}
