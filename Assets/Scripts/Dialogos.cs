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
    public bool playerInRangeNpc3 = false;
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
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            gameManager.dialogo(dialogo);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("TRIGGER DETECTADO: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = true;    
        }
        if (gameObject == Npc3 && collision.gameObject.CompareTag("Player"))
        {
            playerInRangeNpc3 = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerInRange = false;
        }
        if (gameObject == Npc3 && collision.gameObject.CompareTag("Player"))
        {
            playerInRangeNpc3 = false;
        }
    }
}
