using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xingamentoscreator : MonoBehaviour
{
    public GameObject xingamentoPrefab;
    public PlayerPlata player;


    public void xingamento(int pos)
    {
        Debug.Log("Xingamento ativado!");
        Vector2 posicao = new Vector2(20 * pos, player.transform.position.y);
        Instantiate(xingamentoPrefab, posicao, Quaternion.identity);
    }
    
}

    

