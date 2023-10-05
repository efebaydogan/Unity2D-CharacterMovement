using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float xmovement;
    public int xspeed;
    public int jumpForce;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        xmovement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xmovement * xspeed,rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
