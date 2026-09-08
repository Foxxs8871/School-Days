using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joinha : MonoBehaviour
{
    PlayerPlata player;
    Rigidbody2D rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerPlata>();
        GetComponent<Renderer>().material.color = Color.green;
    }

    public void Update()
    {
        movimento();
    }

    public void movimento()
    {
        if (Mathf.Floor(player.transform.position.x) == Mathf.Floor(transform.position.x))
        {
            GetComponent<Renderer>().material.color = Color.red;
            transform.rotation = Quaternion.Euler(180, 0, 0);
            rb.velocity = new Vector2(0, -10f);
        }
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Joinha"))
        {
            Debug.Log("Colidiu com: " + collision.gameObject.name);
        }
    }
    
}
