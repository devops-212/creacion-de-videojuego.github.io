using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public Vector2 direction = Vector2.left;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Invertir dirección al chocar con algo (pared, otro objeto)
        direction = -direction;
    }
}
