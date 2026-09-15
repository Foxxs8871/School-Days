using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xingamento : MonoBehaviour
{
    public Rigidbody2D rb;
    public PlayerPlata player;
    public Vector2 posicao;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        posicao = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        
    }

    void Update()
    {
        movimento();
    }
    public void movimento()
    {
        if (posicao.x > 0)
        {
            rb.velocity = new Vector2(-7.5f, 0);
        }
        else
        {
            rb.velocity = new Vector2(7.5f, 0);
        }
        if (gameObject.transform.position.x < -30f || gameObject.transform.position.x > 30f)
        {
            Destroy(gameObject);
        }
    }
}
