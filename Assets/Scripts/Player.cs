using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 5f;

    public void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical).normalized;
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
