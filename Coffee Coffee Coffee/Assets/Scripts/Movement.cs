using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 1f;
    Rigidbody2D rb;

    PlayerStats ps;

    public bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ps = GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
            float movement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movement * moveSpeed, rb.velocity.y);

        if(movement < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        if (movement > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpPower * 10);
                ps.loseSize();
            }
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}   