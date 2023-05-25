using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //jump
    //move left right
    //double jump
    //Dash
    //Sprint

    public Rigidbody2D rb;
    public Vector2 testVector;
    public Vector2 jumpVector2 = new Vector2 (0.0f, 5.0f);
    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        testVector = rb.velocity; 

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(3.0f, 0.0f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }


        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-3.0f, 0.0f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }


        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(jumpVector2, ForceMode2D.Impulse);
        }
    }

  
}
