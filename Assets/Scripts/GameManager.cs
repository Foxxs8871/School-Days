using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;
    public TextMeshProUGUI text;
    public GameObject CaixaDeTexto;
    public Dialogos dialogoNPC3;
    Dialogos dialogos;

    public void Start()
    {
        player = FindAnyObjectByType<Player>();
        text.gameObject.SetActive(false);
        CaixaDeTexto.SetActive(false);
    }

    public void Update()
    {
        
    if (dialogoNPC3.playerInRangeNpc3)
    {
        Debug.Log("Player is in range of NPC3");
        if (Input.GetKey(KeyCode.C))
        {
            player.transform.position = new Vector3(36, 17, 0);
            player.speed = 5f;
            text.gameObject.SetActive(false);
            CaixaDeTexto.SetActive(false);
        }
    }
    if (Input.GetKey(KeyCode.Q))
        {
            text.gameObject.SetActive(false);
            CaixaDeTexto.SetActive(false);
            player.speed = 5f;
        }

    }
    public void dialogo(string texto)
    {
        player.speed = 0f;
        text.gameObject.SetActive(true);
        CaixaDeTexto.SetActive(true);
        text.text = texto;
    }
}
