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
        if (Input.GetKey(KeyCode.Q))
        {
            text.gameObject.SetActive(false);
            player.speed = 5f;
        }
        if (dialogos.playerInRange == true)
        {
            if (Input.GetKey(KeyCode.C))
            {
                player.transform.position = new Vector3(30, 17, 0);
                text.gameObject.SetActive(false);
                player.speed = 5f;
            }
        }
    }

    public void dialogo(string texto)
    {
        player.speed = 0f;
        text.gameObject.SetActive(true);
        text.text = texto;
    }
}
