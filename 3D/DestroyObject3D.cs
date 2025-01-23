using UnityEngine;

public class DestroyObject3D : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Destruir el enemigo
        }
    }
}
