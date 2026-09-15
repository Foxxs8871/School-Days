using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Moveset20zoar : MonoBehaviour
{

    public TorreCreator torre;
    public joinhacreator joinha;
    public xingamentoscreator xingamentos;

    
    private List<int> sequenciaAtaques = new List<int>();
    public TMP_Text caras;
    private int ataqueAtual = 0;

    void Start()
    {

        StartCoroutine(ciclo());
    }

    IEnumerator ciclo()
    {
        while(true)
        {
            GerarNovaSequencia();

            for (int i= 0; i < sequenciaAtaques.Count; i++)
            {
                MostrarAtaques(sequenciaAtaques[i]);
                yield return new WaitForSeconds(0.5f);
                caras.text = " ";

                yield return new WaitForSeconds(1f);
            }
            caras.text = "";

            ataqueAtual = 0;

            while(ataqueAtual < sequenciaAtaques.Count)
            {
                EscolherAtaque();

                yield return new WaitForSeconds(1f);
            }
        }
    }


    public void EscolherAtaque()
    {
        int ataque = sequenciaAtaques[ataqueAtual];
        
        ataqueAtual++;

        ExecutarAtaque(ataque);
    }
    
    void GerarNovaSequencia()
    {
        sequenciaAtaques.Clear();

        for (int i = 1; i <= 4; i++)
        {
            int a = Random.Range(1, 6);
            sequenciaAtaques.Add(a);
        }

        ataqueAtual = 0;

        Debug.Log("Nova sequência: " + sequenciaAtaques[0] + " " + sequenciaAtaques[1] + " " + sequenciaAtaques[2] + " " + sequenciaAtaques[3]);

    }

public void MostrarAtaques(int ataque)
    {
        switch (ataque)
        {
            case 1:
                Debug.Log("cara 1");
                caras.text = "UwU";
                break;
            case 2:
                Debug.Log("cara 2");
                caras.text = "XD";
                break;
            case 3:
                Debug.Log("cara 3");
                caras.text = "'-'";
                break;
            case 4:
                Debug.Log("cara 4");
                caras.text = ";-;";
                break;
            case 5:
                Debug.Log("cara 5");
                caras.text = ">:O";
                break;
        }
    }

    void ExecutarAtaque(int ataque)
    {
        switch (ataque)
        {
            case 1:
                Debug.Log("Executando Ataque 1");
                torre.torrebinaria();
                break;

            case 2:
                Debug.Log("Executando Ataque 2");
                joinha.joinhas();
                break;

            case 3:
                Debug.Log("Executando Ataque 3");
                xingamentos.xingamento(1);
                break;

            case 4:
                Debug.Log("Executando Ataque 4");
                xingamentos.xingamento(-1);
                break;

            case 5:
                Debug.Log("Executando Ataque 5");
                break;
        }
    }
}
