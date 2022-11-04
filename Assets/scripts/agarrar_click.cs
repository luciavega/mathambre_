using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class agarrar_click : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
