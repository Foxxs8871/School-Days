using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoteInvestida : MonoBehaviour
{
    public Transform playerpos;
    public Rigidbody2D rb;
    public Zote zote;
    public Vector3 direcao;

    public void Awake()
    {
        playerpos = FindAnyObjectByType<Player>().transform;
    }
    
    public void Investida()
    {
        direcao = (playerpos.transform.position - transform.position).normalized;
        StartCoroutine(InvestidaCoroutine());
    }
    IEnumerator InvestidaCoroutine()
    {
        float velocidade = zote.velocidade;
        zote.velocidade = zote.velocidade * 3f;
        yield return new WaitForSeconds(1f);
        zote.velocidade = velocidade;
        
    }
}
