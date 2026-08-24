using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogos : MonoBehaviour
{
    public int npcNumber = 0;
    public GameManager gameManager;
    private Player player;
    public bool playerInRange = false;
    public GameObject Npc1;
    public GameObject Npc2;
    public GameObject Npc3;
    public GameObject Npc4;
    public string dialogo = "Placeholder";

    public void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        player = FindAnyObjectByType<Player>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("TRIGGER DETECTADO: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (gameObject == Npc1)
                {
                    gameManager.dialogo(dialogo);
                }
                else if (gameObject == Npc2)
                {
                    gameManager.dialogo(dialogo);
                }
                else if (gameObject == Npc3)
                {
                    gameManager.dialogo(dialogo);
                }
                else if (gameObject == Npc4)
                {
                    gameManager.dialogo(dialogo);
                }
            }


        }
    }
}
