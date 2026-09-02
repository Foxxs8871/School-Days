using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;
    public TextMeshProUGUI text;
    public GameObject CaixaDeTexto;
    public Dialogos dialogos;

    public void Start()
    {
        player = FindAnyObjectByType<Player>();
        text.gameObject.SetActive(false);
        CaixaDeTexto.SetActive(false);
    }

    public void dialogo(string texto)
    {
        player.speed = 0f;
        text.gameObject.SetActive(true);
        CaixaDeTexto.SetActive(true);
        text.text = texto;
    }
//
    public void Dialogo1()
    {
        Debug.Log("Dialogo 1");
        if (dialogos.ColidindoNpc == 1)
        {
            player.speed = 5f;
            CaixaDeTexto.SetActive(false);
        }
        else if (dialogos.ColidindoNpc == 2)
        {
            player.speed = 5f;
            CaixaDeTexto.SetActive(false);
        }
        else if (dialogos.ColidindoNpc == 3)
        {
            player.transform.position = new Vector3(36, 17, 0);
            player.speed = 5f;
            CaixaDeTexto.SetActive(false);
        }
        else if (dialogos.ColidindoNpc == 4)
        {
            player.speed = 5f;
            CaixaDeTexto.SetActive(false);
        }
    }

    public void Dialogo2()
    {
        CaixaDeTexto.SetActive(false);
        player.speed = 5f;
    }

}
