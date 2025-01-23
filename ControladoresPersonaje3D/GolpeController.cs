using UnityEngine;

public class GolpeController : MonoBehaviour
{
    // Referencia al Rigidbody del personaje
    private Rigidbody rb;

    // Fuerza del golpe
    public float fuerzaGolpe = 10.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Golpear
        if (Input.GetButtonDown("Attack"))
        {
            Golpear();
        }
    }

    void Golpear()
    {
        // Aquí puedes agregar el código para golpear
        Debug.Log("Golpeando");

        // Fuerza del golpe
        rb.AddForce(transform.forward * fuerzaGolpe, ForceMode.Impulse);
    }
}