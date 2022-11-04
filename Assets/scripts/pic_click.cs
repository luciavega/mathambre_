using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pic_click : MonoBehaviour

{
    public static pic_click inst;

    void Awake()
    {

        Scene scene = SceneManager.GetActiveScene();

        if (pic_click.inst == null)
        {
            //primera vez
            pic_click.inst = this;
            DontDestroyOnLoad(gameObject);

        }

        else
        {
            //ya hay una instancia? eliminarla
            Destroy(gameObject);
        }

    }
    

}
