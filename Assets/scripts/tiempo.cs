﻿using UnityEngine;
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
        timeTF.GetComponent<Text>().text = "120";
        InvokeRepeating("ReduceTime", 1, 1);
    }
    void ReduceTime()
    {
        if (timeTF.GetComponent<Text>().text == "1")
        {
            SceneManager.LoadScene("7");
        }

        timeTF.GetComponent<Text>().text = (int.Parse(timeTF.GetComponent<Text>().text) - 1).ToString();
    }
}