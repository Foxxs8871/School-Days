using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlata : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 100f;
    public bool canJump = true;
    private bool dash = true;
    private float dashDuration = 0.1f;
    private float dashCooldown = 1f;
    private float dashCooldownTimer = 0f;
    private float dashTimer = 0f;
    
    public Rigidbody2D rb;
    
    public void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        if (movement != 0)
        {
            rb.velocity = new Vector2(movement * speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce * 1.6f);
            canJump = false;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && rb.velocity.y > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        
        if (dash == false)
        {
            
            if (dashCooldownTimer >= dashCooldown)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    dash = true;
                }
            }
        }
    }

    public void FixedUpdate()
    {
        Dash();
    }

    public void Dash()
    {
        if (dash == true)
        {
            
            dashCooldownTimer = 0f;
            speed = 30f;

            dashTimer += Time.fixedDeltaTime;

            if (dashTimer >= dashDuration)
            {
                dash = false;
                dashTimer = 0f;
                speed = 5f;
            }
        }
        else
        {
            dashCooldownTimer += Time.fixedDeltaTime;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = false;
        }
    }
}
