using UnityEngine;

public class BallController : MonoBehaviour
{
    public float launchForce = 500f; // Fuerza con la que se lanza la bola
    public bool isLaunched = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!isLaunched && Input.GetKeyDown(KeyCode.Space))
        {
            LaunchBall();
        }
    }

    void LaunchBall()
    {
        rb.AddForce(Vector3.forward * launchForce); // Lanza la bola hacia adelante
        isLaunched = true;
    }

    public void ResetBall(Vector3 startPosition)
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = startPosition;
        isLaunched = false;
    }
}
