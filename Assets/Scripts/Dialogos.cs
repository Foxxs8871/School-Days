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

    public void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        player = FindAnyObjectByType<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("Player entrou na área de diálogo do NPC " + npcNumber);
            if (Input.GetKey(KeyCode.E))
            {
                if (npcNumber == 1)
                {
                    gameManager.dialogo("Dialogo do npc 1");
                }
                else if (npcNumber == 2)
                {
                    gameManager.dialogo("Dialogo do npc 2");
                }
                else if (npcNumber == 3)
                {
                    gameManager.dialogo("bora brigar la no parquinho meno");
                    playerInRange = true;
                }
                else if (npcNumber == 4)
                {
                    gameManager.dialogo("Dialogo do npc 4");

                }
            }
        }
    }
}
