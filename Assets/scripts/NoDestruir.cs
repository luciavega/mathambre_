using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestruir : MonoBehaviour
{

    public static NoDestruir inst;

    // Start is called before the first frame update
    void Start()
    {
        if (NoDestruir.inst == null)
        {
            //primera vez
            NoDestruir.inst = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            //ya hay una instancia? eliminarla
            Destroy(gameObject);
        }

       
    }
}
