using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Player player;
    public TextMeshProUGUI text;
    private Dialogos dialogos;

    private void Start()
    {
        player = FindAnyObjectByType<Player>();
        text.gameObject.SetActive(false);
        dialogos = FindAnyObjectByType<Dialogos>();
    }

    private void Update()
    {
        
        if (gameObject == dialogos.Npc3 && Input.GetKeyDown(KeyCode.C))
        {
            player.transform.position = new Vector3(36, 17, 0);
            player.speed = 5f;
            text.gameObject.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            text.gameObject.SetActive(false);
            player.speed = 5f;
        }

    }
    public void dialogo(string texto)
    {
        player.speed = 0f;
        text.gameObject.SetActive(true);
        text.text = texto;
    }
}
