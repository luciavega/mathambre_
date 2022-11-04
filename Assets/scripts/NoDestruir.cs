using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NoDestruir : MonoBehaviour
{
    timer timer;

    public static NoDestruir inst;

    // Start is called before the first frame update
    void Awake()
    {

        Scene scene = SceneManager.GetActiveScene();

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
