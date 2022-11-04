using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloj : MonoBehaviour
{
    public static reloj inst;

    void Awake()
    {
        if (reloj.inst == null)
        {
            //primera vez
            reloj.inst = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //ya hay una instancia? eliminarla
            Destroy(gameObject);
        }


    }
}
