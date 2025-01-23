using UnityEngine;

public class PersonajeController : MonoBehaviour
{
    // Velocidad de movimiento
    public float velocidad = 5.0f;

    // Fuerza de salto
    public float fuerzaSalto = 10.0f;

    // Velocidad de corrida
    public float velocidadCorrida = 10.0f;

    // Referencia al Rigidbody del personaje
    private Rigidbody rb;

    // Estado del personaje
    private bool isSaltando = false;
    private bool isAgachado = false;
    private bool isCorriendo = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento
        float movimientoX = Input.GetAxis("Horizontal");
        float movimientoZ = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoX, 0, movimientoZ);

        rb.AddForce(movimiento * velocidad);

        // Salto
        if (Input.GetButtonDown("Jump") && !isSaltando)
        {
            isSaltando = true;
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }

        // Agacharse
        if (Input.GetButtonDown("Crouch") && !isAgachado)
        {
            isAgachado = true;
            transform.localScale = new Vector3(1, 0.5f, 1);
        }
        else if (Input.GetButtonUp("Crouch") && isAgachado)
        {
            isAgachado = false;
            transform.localScale = new Vector3(1, 1, 1);
        }

        // Correr
        if (Input.GetButtonDown("Run") && !isCorriendo)
        {
            isCorriendo = true;
            velocidad = velocidadCorrida;
        }
        else if (Input.GetButtonUp("Run") && isCorriendo)
        {
            isCorriendo = false;
            velocidad = 5.0f;
        }

        // Golpear
        if (Input.GetButtonDown("Attack"))
        {
            // Aquí puedes agregar el código para golpear
            Debug.Log("Golpeando");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si el personaje choca con el suelo, detiene el salto
        if (collision.gameObject.CompareTag("Ground") && isSaltando)
        {
            isSaltando = false;
        }
    }
}