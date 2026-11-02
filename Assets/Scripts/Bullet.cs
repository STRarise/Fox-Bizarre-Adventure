using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    public void Launch(float dir)
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(dir * speed, 0f);
        transform.localScale = new Vector3(dir, 1f, 1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
