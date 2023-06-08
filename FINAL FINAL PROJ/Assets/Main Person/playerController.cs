using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //jump - Check
    //move left right - Check
    //double jump
    //Dash
    //Sprint - Check
    public float walkSpeed = 5f;
    public float sprintSpeed = 10f;
    public Rigidbody2D rb;
    public float jumpForce = 5.7f;
    public Collider2D groundCheck;
    public bool isGrounded;
    public int doubleJump;
    public int health = 5;
    [SerializeField] Health healthbar;
    public gameOver gameOver;
    bool isDead = false;
    
    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        groundCheck = gameObject.GetComponent<Collider2D>();
       
    }

    // Update is called once per frame
    void Update()
    {

        if (!isDead)
        {
            if (Input.GetButton("Fire3"))
            {
                rb.velocity = new Vector2(Input.GetAxis("Horizontal") * sprintSpeed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(Input.GetAxis("Horizontal") * walkSpeed, rb.velocity.y);
            }

            if ((Input.GetButtonDown("Jump") && isGrounded && doubleJump >= 0) || (Input.GetButtonDown("Jump") && doubleJump >= 0))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                doubleJump--;
            }
        }
        if(health <= 0)
        {
            gameOver.Setup();
            isDead = true;
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            health--;
            isGrounded = true;
            doubleJump = 1;
            healthbar.decreaseHealth();
        }

        if (col.gameObject.tag == "Terrain")
        {
            isGrounded = true;
            doubleJump = 1;
        }
       



    }

        void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Terrain")
        {
            isGrounded = false;
        }
    }
}
