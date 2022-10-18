using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambio_pinicial : MonoBehaviour
{
    public Transform puntoInicial;
    public GameObject personaje;
    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Player");
        puntoInicial = GameObject.FindGameObjectWithTag("PuntoInicial").transform;
        MoverApuntoInicial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoverApuntoInicial()
    {
        personaje.transform.position = puntoInicial.position;
    }
}
