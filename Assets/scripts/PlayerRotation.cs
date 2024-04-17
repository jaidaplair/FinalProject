using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] float jumpForce = 10f;
    [SerializeField] float rotation = -13f; // Adjust the rotation speed as needed
    private bool doubleJump;
    private float doubleJumpingPower = 10f;

    bool isGrounded = false;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
           // rb.velocity = new Vector2(rb.velocity.x, doubleJump ? doubleJumpingPower : jumpForce);
            rb.AddTorque(rotation);
            doubleJump = !doubleJump;
            doubleJump = false;
        }*/


        // Jump when Space key is pressed and the player is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //if((isGrounded) || doubleJump)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
               // rb.velocity = new Vector2(rb.velocity.x, doubleJump ? doubleJumpingPower : jumpForce);
                rb.AddTorque(rotation);
                doubleJump = !doubleJump;
                //animator.SetTrigger();

                // Rotate the player
                // StartCoroutine(RotatePlayer(90f));
            }
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else
        {
            // Destroy the object collided with if it has a hit tag
            if (collision.gameObject.CompareTag("Hit"))
            {
                // Destroy(collision.gameObject);
                Destroy(gameObject);//destroy player
                //Destroy(ParticleSystem);
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
