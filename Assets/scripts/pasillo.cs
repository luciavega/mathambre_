﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasillo : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if(collision.gameObject.tag == "Player")
    {
        SceneManager.LoadScene(0);

    }
   }
}
