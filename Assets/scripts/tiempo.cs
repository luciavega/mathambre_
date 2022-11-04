using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tiempo : MonoBehaviour
{

    public GameObject timeTF;
    public GameObject alertReference;

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        timeTF.GetComponent<Text>().text = "10";
        InvokeRepeating("ReduceTime", 1, 1);

        if (timeTF.GetComponent<Text>().text == "0")
        {
            SceneManager.LoadScene("7");
        }
    }
    void ReduceTime()
    {
        timeTF.GetComponent<Text>().text = (int.Parse(timeTF.GetComponent<Text>().text) - 1).ToString();
    }
}