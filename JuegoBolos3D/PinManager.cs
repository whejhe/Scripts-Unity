using UnityEngine;

public class PinManager : MonoBehaviour
{
    public Transform[] pins; // Array de posiciones iniciales de los bolos

    private Vector3[] initialPositions;

    void Start()
    {
        initialPositions = new Vector3[pins.Length];
        for (int i = 0; i < pins.Length; i++)
        {
            initialPositions[i] = pins[i].position;
        }
    }

    public void ResetPins()
    {
        for (int i = 0; i < pins.Length; i++)
        {
            pins[i].position = initialPositions[i];
            pins[i].rotation = Quaternion.identity;

            Rigidbody rb = pins[i].GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
