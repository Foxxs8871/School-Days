using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaZote : MonoBehaviour
{
    public Transform playerpos;
    float velocidade = 10f;

    public Vector2 direcao;
    private Rigidbody2D rb;

    void Start()
    {
        playerpos = FindAnyObjectByType<Player>().transform;
        rb = GetComponent<Rigidbody2D>();
        direcao = (playerpos.transform.position - transform.position).normalized;
        JogarBola();
    }

    public void JogarBola()
    {
        rb.velocity = direcao * velocidade;
    }
        
}
