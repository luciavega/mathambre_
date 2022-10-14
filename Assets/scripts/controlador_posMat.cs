using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador_posMat : MonoBehaviour { 

    public GameObject mat;
    private Vector3 posicionRelativa;


    // Start is called before the first frame update
    void Start()
    {
        posicionRelativa = transform.position - mat.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = mat.transform.position + posicionRelativa;
    }
}
