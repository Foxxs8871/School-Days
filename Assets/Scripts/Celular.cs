using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Celular : MonoBehaviour
{
    public GameObject celular;
    public GameObject panel;
    public Player player;
    public int AppNum = 0;

    void Start()
    {
        player = FindAnyObjectByType<Player>();
    }
    public void AlternarCelular()
    {
        if (celular.activeSelf == false)
        {
        celular.SetActive(true);
        panel.SetActive(true);
        player.speed = 0f;
        }

        else if (celular.activeSelf == true)
        {
        celular.SetActive(false);
        panel.SetActive(false);
        player.speed = 5f;
        }
    }
    

    public void AbrirApp()
    {
        if (gameObject.CompareTag("App1"))
        {
            Debug.Log("App 1");
        }
        else if (gameObject.CompareTag("App2"))
        {
            Debug.Log("App 2");
        }
        else if (gameObject.CompareTag("App3"))
        {
            Debug.Log("App 3");
        }
        else if (gameObject.CompareTag("App4"))
        {
            Debug.Log("App 4");
        }
        else if (gameObject.CompareTag("App5"))
        {
            Debug.Log("App 5");
        }
        else if (gameObject.CompareTag("App6"))
        {
            Debug.Log("App 6");
        }
        
        
    }
}
