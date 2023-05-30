using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //jump
    //move left right - Check
    //double jump
    //Dash
    //Sprint - Check
    public float walkSpeed = 5f;
    public float sprintSpeed = 10f;
    public Rigidbody2D rb;
    public float jumpForce = 5.7f;
    public Collider2D groundCheck;
    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        groundCheck = gameObject.GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButton("Fire3"))
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * sprintSpeed, rb.velocity.y);
        } else
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * walkSpeed, rb.velocity.y);
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
        }

        
    }

  
}
