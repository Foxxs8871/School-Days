using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private bool dash = true;
    private float dashDuration = 0.15f;
    private float dashCooldown = 0.5f;
    private float dashCooldownTimer = 0f;
    private float dashTimer = 0f;

    public void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical);
        if (horizontal != 0 && vertical != 0)
        {
            movement = new Vector2(horizontal, vertical).normalized;
        }
        transform.Translate(movement * speed * Time.deltaTime);

        if (dash == false)
        {
            
            if (dashCooldownTimer >= dashCooldown)
            {
                if (Input.GetKeyDown(KeyCode.Space))
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


}
