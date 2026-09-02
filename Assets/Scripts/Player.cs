using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private bool dash = true;
    private float dashDuration = 0.15f;
    private float dashCooldown = 0.5f;
    private float dashCooldownTimer = 0f;
    private float dashTimer = 0f;
    public MainCamera Camera;
    public Dialogos dialogos;

    void Start()
    {
        speed = 5f;
        Camera = FindAnyObjectByType<MainCamera>();
    }
    public void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical).normalized;
        // if (horizontal != 0 && vertical != 0)
        // {
        //     movement = new Vector2(horizontal, vertical).normalized;
        // }
        transform.Translate(movement * speed * Time.deltaTime);

        if (dash == false)
        {
            
            if (dashCooldownTimer >= dashCooldown)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    dash = true;
                }
            }
        }
    }

    public void FixedUpdate()
    {
        Dash();
    }

    public void Dash()
    {
        if (dash == true)
        {
            
            dashCooldownTimer = 0f;
            speed = 30f;

            dashTimer += Time.fixedDeltaTime;

            if (dashTimer >= dashDuration)
            {
                dash = false;
                dashTimer = 0f;
                speed = 5f;
            }
        }
        else
        {
            dashCooldownTimer += Time.fixedDeltaTime;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("FrenteDaEscola"))
        {
            Camera.posicaoCamera("escola");
        }
        if (collision.gameObject.CompareTag("MuroDaEscola"))
        {
            Camera.posicaoCamera("rua");
        }
        if (collision.gameObject.CompareTag("DireitaDaEscola"))
        {
            Camera.posicaoCamera("parquinho");
        }
        if (collision.gameObject.CompareTag("EsquerdaDaEscola"))
        {
            Camera.posicaoCamera("galpao");
        }

        if (collision.gameObject.CompareTag("Npc1"))
        {
            dialogos.ColidindoNpc = 1;
        }
        else if (collision.gameObject.CompareTag("Npc2"))
        {
            dialogos.ColidindoNpc = 2;
        }
        else if (collision.gameObject.CompareTag("Npc3"))
        {
            dialogos.ColidindoNpc = 3;
        }
        else if (collision.gameObject.CompareTag("Npc4"))
        {
            dialogos.ColidindoNpc = 4;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Npc1") || collision.gameObject.CompareTag("Npc2") || collision.gameObject.CompareTag("Npc3") || collision.gameObject.CompareTag("Npc4"))
        {
            dialogos.ColidindoNpc = 0;
        }
    }
    
}
