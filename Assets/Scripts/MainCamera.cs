using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    Vector3 posicaoescola = new Vector3(0, 17, -10);
    Vector3 posicaorua = new Vector3(0, 0, -10);
    Vector3 posicaoparquinho = new Vector3(30, 13, -10);
    Vector3 posicaogalpao = new Vector3(-30, 12, -10);

    private List<string> posicao = new List<string>()
    {
        
    };

    // Update is called once per frame
    void MudarPos()
    {
        Camera.main.transform.position = posicaorua;
    }
}
