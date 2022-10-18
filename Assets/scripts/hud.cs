using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class hud : MonoBehaviour
{

    public static hud inst;
    // Start is called before the first frame update
    void Awake()
    {
        if (hud.inst == null)
        {
            //primera ves
            hud.inst = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //ya hay una instancia? eliminarla
            Destroy(gameObject);
        }
    }

}
