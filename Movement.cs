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
    public bool onFloor;
    public bool faceRight = true;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        xmovement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xmovement * xspeed,rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            onfloor = false;
        }

        if(faceRight == true && xmovement < 0) 
        {
            Turn();
        }

        else if(faceRight == false && xmovement > 0)
        {
            Turn();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "floor") //In the Unity game you need to make your floor tag "floor".()
        {
            onFloor = true;//When you click on the floor in Unity, there is a tag in the upper right corner, you can change it from there.
        }
    }

    void Turn() 
    {
        faceRight = !faceRight;
        Vector2 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
