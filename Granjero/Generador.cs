using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject[] animalesPrefabs;
    private float rangoXGenerador = 20f;
    private float rangoZGenerador = 20f;
    private float retardoInicial = 2.0f;
    private float intervaloGenaracion = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarAnimalesAleatorios", retardoInicial, intervaloGenaracion);
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.S)){
        //     GenerarAnimalesAleatorios();
        // }
    }

    void GenerarAnimalesAleatorios(){
        int indexAnimal = Random.Range(0, animalesPrefabs.Length);
        Vector3 posicionGenerador = new Vector3(Random.Range(-rangoXGenerador, rangoXGenerador), 0, rangoZGenerador);
        Instantiate(animalesPrefabs[indexAnimal], posicionGenerador, animalesPrefabs[indexAnimal].transform.rotation);
    }
}
