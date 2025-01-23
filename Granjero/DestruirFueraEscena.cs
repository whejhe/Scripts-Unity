using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirFueraEscena : MonoBehaviour
{
    float limiteSuperior = 30;
    float limiteInferior = -15;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if(transform.position.z > limiteSuperior || transform.position.z < limiteInferior){
        //     Destroy(gameObject);
        // }
        if (transform.position.z > limiteSuperior)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < limiteInferior)
        {
            Destroy(gameObject);
            Debug.Log("Fin de la Partida");
        }
    }
}
