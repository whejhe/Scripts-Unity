using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool hasFallen = false;

    void Update()
    {
        if (!hasFallen && transform.up.y < 0.5f) // Verifica si el bolo ha caído
        {
            hasFallen = true;
            FindObjectOfType<ScoreManager>().AddScore(1); // Suma un punto por bolo derribado
        }
    }
}
