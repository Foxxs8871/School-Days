using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogos : MonoBehaviour
{
    public int npcNumber = 0;
    public GameManager gameManager;
    private Player player;


    public int ColidindoNpc = 0;

    public GameObject Npc1;
    public GameObject Npc2;
    public GameObject Npc3;
    public GameObject Npc4;

    //Dialogos
    public string Opcao1;
    public string Opcao2;

    public TMP_Text Opcao1Text;
    public TMP_Text Opcao2Text;

    public string dialogo = "Placeholder";

    public void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        player = FindAnyObjectByType<Player>();
    }
    void Update()
    {
        Opcao1Text.text = Opcao1;
        Opcao2Text.text = Opcao2;

        if (ColidindoNpc != 0 && Input.GetKeyDown(KeyCode.E))
        {
            gameManager.dialogo(dialogo);
        }

        if (ColidindoNpc == 1)
        {
            dialogo = "Oi";
            Opcao1 = "Oi também fofa";
            Opcao2 = "Tchau fofa";
        }
        else if (ColidindoNpc == 2)
        {
            dialogo = "Oi, voce quer ver o jornal da escola?";
            Opcao1 = "Sim, por favor";
            Opcao2 = "Não, obrigado";
        }
        else if (ColidindoNpc == 3)
        {
            dialogo = "Desafiar valentão?";
            Opcao1 = "Sim, por favor";
            Opcao2 = "Não, obrigado";
        }
        else if (ColidindoNpc == 4)
        {
            dialogo = "Auau";
            Opcao1 = "Oq vc estava fazendo durante a restauração do facismo?";
            Opcao2 = "Carinho carinho";
        }

    }
}
