using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoteInvestida : MonoBehaviour
{
    public Transform playerpos;
    public Vector2 direcao;
    public Rigidbody2D rb;
    public Zote zote;

    public void Investida()
    {
        playerpos = FindAnyObjectByType<Player>().transform;
        direcao = (playerpos.transform.position - transform.position).normalized;
        StartCoroutine(InvestidaCoroutine());
    }
    IEnumerator InvestidaCoroutine()
    {
        zote.Follow(0);
        rb.velocity = direcao * 3f;
        yield return new WaitForSeconds(1f);
        zote.Follow(1);
    }
}
