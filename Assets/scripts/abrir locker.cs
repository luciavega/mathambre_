using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class abrirlocker : MonoBehaviour
{

    private void Awake()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SceneManager.LoadScene(8);
        }
    }
   


}
