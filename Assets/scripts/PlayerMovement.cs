using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed = 8f;
    
   // [SerializeField] float jumpForce = 10f;
  //  [SerializeField] float rotationSpeed = 200f; // Adjust the rotation speed as needed
    
    bool isGrounded = false;
    Rigidbody2D rb;
    Animator animator;
    GameManager gameManager; // Reference to the GameManager script
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
        gameManager = FindObjectOfType<GameManager>();

    }

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        // Move the player horizontally
       // transform.Translate(Vector2.right * speed * Time.deltaTime);//,Space.World);
        // Check if the player is moving left
        //if (Input.GetAxis("Horizontal") < 0)
       // {
            // Call Restart() from GameManager if the player moves left
          //  gameManager.Restart();
       // }
        /*
        // Jump when Space key is pressed and the player is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            rb.AddTorque(rotationSpeed);
            //animator.SetTrigger();

            // Rotate the player
           // StartCoroutine(RotatePlayer(90f));
        }*/
    }
    /*
    IEnumerator RotatePlayer(float targetAngle)
    {
        float startAngle = transform.eulerAngles.z;
        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime * rotationSpeed;
            float angle = Mathf.Lerp(startAngle, targetAngle, t);
            transform.eulerAngles = new Vector3(0, 0, angle);
            yield return null;
        }
        transform.eulerAngles = new Vector3(0, 0, targetAngle);
        yield return null;
    }*/

    // Check if the player is grounded
   /* void OnCollisionEnter2D(Collision2D collision)
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
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }*/
}

