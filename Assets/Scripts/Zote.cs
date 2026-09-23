using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zote : MonoBehaviour
{
    public float velocidade = 2f;
    public Transform playerpos;
    public GameObject bolaPrefab;
    public Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerpos = FindAnyObjectByType<Player>().transform;
    }

    void FixedUpdate()
    {
        Follow();
    }

    public void Follow(int parar = 1)
    {
        Vector3 direcao = (playerpos.position - transform.position).normalized;
        rb.velocity = direcao * velocidade * parar;
        //gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, playerpos.position, velocidade * parar);
    }

    public void CriarBola()
    {
        Instantiate(bolaPrefab, transform.position, Quaternion.identity);
    }
}

    


