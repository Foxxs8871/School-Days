using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joinhacreator : MonoBehaviour
{
    public GameObject joinha;
    
    public void joinhas()
    {
        Vector2 posicao = new Vector2(Random.Range(-10, 10), transform.position.y);
        Instantiate(joinha, posicao, Quaternion.identity);
    }
}
