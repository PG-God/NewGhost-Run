using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jamp : MonoBehaviour
{
    public Rigidbody2D rigit2D;
    public float jumpForce = 680.0f; 
    
    void Start()
    {
       rigit2D = GetComponent<Rigidbody2D>();
    }

    public void JampFunction()
    {
        rigit2D.AddForce(transform.up * jumpForce);
        Debug.Log("a");
    }




}
