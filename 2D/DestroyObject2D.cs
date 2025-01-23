using UnityEngine;

public class DestroyObject2D : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Destruir el enemigo
        }
    }
}
