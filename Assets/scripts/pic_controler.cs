﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pic_controler : MonoBehaviour
{

   
    private void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
                Destroy(gameObject);
                
        }
    }
    
}
