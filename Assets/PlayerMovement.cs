using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 8f;
    [SerializeField] float forceX = 1f;
    [SerializeField] float forceY = 10f;
    SpriteRenderer spriteRenderer;
    //Rigidbody2D rb;

    public float jumpForce = 10f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed* Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            //rb.AddForce(forceY * Vector2.up);//applying upward force
            
            //spriteRenderer.flipX = false;

        }
    }
}
