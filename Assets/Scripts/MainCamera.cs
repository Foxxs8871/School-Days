using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    Player player;
    Vector3 posicaoescola = new Vector3(0, 17, -10);
    Vector3 posicaorua = new Vector3(0, 0, -10);
    Vector3 posicaoparquinho = new Vector3(30, 13, -10);
    Vector3 posicaogalpao = new Vector3(-30, 12, -10);

    private void OnTriggerEnter2D(Collider2D playerCollider)
    {
        
    }
    public void posicaoCamera(string local)
    {
        if (local == "escola")
        {
            transform.position = posicaoescola;
        }
        else if (local == "rua")
        {
            transform.position = posicaorua;
        }
        else if (local == "parquinho")
        {
            transform.position = posicaoparquinho;
        }
        else if (local == "galpao")
        {
            transform.position = posicaogalpao;
        }
    }
    
}
