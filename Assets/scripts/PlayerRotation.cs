/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] float jumpForce = 10f;
    [SerializeField] float rotation = -13f; // Adjust the rotation speed as needed
    [SerializeField] new ParticleSystem particleSystem; // Reference to the particle system
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
/*

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
        // Enable/disable particle system based on player's grounded state
        if (particleSystem != null)
        {
            if (isGrounded)
                particleSystem.Play();
            else
                particleSystem.Stop();
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
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerRotation : MonoBehaviour
{
    [SerializeField] float jumpForce = 10f;
    [SerializeField] float rotation = -13f;
    [SerializeField] ParticleSystem particleSystem; // Reference to the particle system
    [SerializeField] ParticleSystem particleSystems;
    [SerializeField] AudioClip death;
    private bool doubleJump;
    private float doubleJumpingPower = 10f;
    [SerializeField] PlayerMovement pm;

    bool isGrounded = false;
    Rigidbody2D rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)//one jump
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            rb.AddTorque(rotation);
            doubleJump = true; // Enable double jump when grounded
        }
        else if (Input.GetKeyDown(KeyCode.Space) && doubleJump)// if holding now space bar then it continuously jumps back to back
        {
            rb.velocity = new Vector2(rb.velocity.x, doubleJumpingPower);
            rb.AddTorque(rotation);
            doubleJump = false; // Disable double jump after performing it
        }

        // Enable/disable particle system based on player's grounded state
        if (particleSystem != null)
        {
            if (isGrounded)
                particleSystem.gameObject.SetActive(true);//plays
            else
                particleSystem.gameObject.SetActive(false);//turns off
        }
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {   //find and return the first object you see with a gamemanager component in it
        GameManager gm;
        gm = FindAnyObjectByType<GameManager>();

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Hit"))
        {
            // Destroy(gameObject,2f);
            //increment score
            audioSource.PlayOneShot(death);
            gm.score += 1;
            Destroy(gameObject, 2f);
        }



       // Destroy(collision.gameObject);//destroy object we hit
        //Destroy(gameObject);//destroy the fireball
        //Debug.Log("Ive been triggered!!!!!!!!!"+ collision.name);
    }*/
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager gm;
        gm = FindAnyObjectByType<GameManager>();
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Hit"))
        {
            // Destroy(gameObject,2f);
            //increment score
            audioSource.PlayOneShot(death);//play sound when i die
           // audioSource.clip = death;
            //audioSource.Play();
            //gm.score += 1;
            Destroy(gameObject, .17f);
            particleSystems.Play();// turn on explosion particles
            particleSystem.Stop();//turn off stream
           

            //pm.speed = 0;
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


