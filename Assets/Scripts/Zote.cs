using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zote : MonoBehaviour
{
    private float velocidade = 0.0f;
    private Transform playerpos;
    public GameObject bolaPrefab;

    void Start()
    {
        playerpos = FindAnyObjectByType<Player>().transform;
        CriarBola();
    }

    void FixedUpdate()
    {
        Follow();
    }

    public void Follow()
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, playerpos.position, velocidade);
    }

    public void CriarBola()
    {
        Instantiate(bolaPrefab, transform.position, Quaternion.identity);
    }
}

    


