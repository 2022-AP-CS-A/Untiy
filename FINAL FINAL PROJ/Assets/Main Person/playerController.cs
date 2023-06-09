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
    public Rigidbody2D rb;
    public float jumpForce = 5.7f;
    public Collider2D groundCheck;
    public bool isGrounded;
    public int doubleJump;
    public int health = 3;
    public bool locked = false;
    [SerializeField] HealthBar healthbar;
    public gameOver gameOverScreen;
    public gameWin gameWinScreen;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        groundCheck = gameObject.GetComponent<Collider2D>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!locked)
        {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * walkSpeed, rb.velocity.y);


            if ((Input.GetButtonDown("Jump") && isGrounded && doubleJump >= 0) || (Input.GetButtonDown("Jump") && doubleJump >= 0))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                doubleJump--;
            }
        }
        if (health <= 0)
        {
            locked = true;
            gameOverScreen.Setup();
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            health--;
            isGrounded = true;
            doubleJump = 1;
            healthbar.setHealth(health);
            source.Play();
        }

        if (col.gameObject.tag == "InstantKill")
        {
            health = 0;
            healthbar.setHealth(health);
            source.Play();

        }

        if (col.gameObject.tag == "Terrain")
        {
            isGrounded = true;
            doubleJump = 1;
        }
        Debug.Log("wefwef");
        if (col.gameObject.tag == "FinishLine")
        {
            locked = true;
            gameWinScreen.Setup();
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
