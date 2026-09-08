using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Moveset20zoar : MonoBehaviour
{

    public TorreCreator torre;
    public joinhacreator joinha;

    
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

                yield return new WaitForSeconds(1f);
            }
            //caras.text = "";

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
    public void MostrarAtaques(int ataque)
    {
        switch (ataque)
        {
            case 1:
                Debug.Log("cara 1");
                break;
            case 2:
                Debug.Log("cara 2");
                break;
            case 3:
                Debug.Log("cara 3");
                break;
            case 4:
                Debug.Log("cara 4");
                break;
        }
    }

    void GerarNovaSequencia()
    {
        sequenciaAtaques.Clear();

        sequenciaAtaques.Add(1);
        sequenciaAtaques.Add(2);
        sequenciaAtaques.Add(3);
        sequenciaAtaques.Add(4);

        for (int i = sequenciaAtaques.Count - 1; i > 0; i--)
        {
            int indiceAleatorio = Random.Range(0, i + 1);

            int temp = sequenciaAtaques[i];
            sequenciaAtaques[i] = sequenciaAtaques[indiceAleatorio];
            sequenciaAtaques[indiceAleatorio] = temp;

        }

        ataqueAtual = 0;

        Debug.Log("Nova sequência: " + sequenciaAtaques[0] + " " + sequenciaAtaques[1] + " " + sequenciaAtaques[2] + " " + sequenciaAtaques[3]);

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
                break;

            case 4:
                Debug.Log("Executando Ataque 4");
                break;
        }
    }
}
