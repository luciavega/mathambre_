using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasaje : MonoBehaviour
{

    private Animator _pasajeAnim;
    // Start is called before the first frame update
    void Start()
    {
        _pasajeAnim = GetComponent<Animator>();
    }
     private void LoadScene(string scene)
    {
        StartCoroutine(Transiciona(scene));
    }
    IEnumerator Transiciona(string scene)
    {
        _pasajeAnim.SetTrigger("salida");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("2");
    }
  
}
