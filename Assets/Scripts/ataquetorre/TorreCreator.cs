using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreCreator : MonoBehaviour
{
    public GameObject torre;
    public Rigidbody2D rb;

    public void torrebinaria()
    {
        Debug.Log("Torre Binária ativada!");
        Instantiate(torre, transform.position, Quaternion.identity);
        rb.velocity = new Vector2(0, -10f);
    }
    
    
}
