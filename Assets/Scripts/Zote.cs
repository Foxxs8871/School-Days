using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zote : MonoBehaviour
{
    public float velocidade = 0.05f;
    private Transform playerpos;
    public GameObject bolaPrefab;

    void Start()
    {
        playerpos = FindAnyObjectByType<Player>().transform;
    }

    void FixedUpdate()
    {
        Follow();
    }

    public void Follow(int parar = 1)
    {
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, playerpos.position, velocidade * parar);
    }

    public void CriarBola()
    {
        Instantiate(bolaPrefab, transform.position, Quaternion.identity);
    }
}

    


