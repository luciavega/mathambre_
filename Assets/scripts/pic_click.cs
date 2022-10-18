using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pic_click : MonoBehaviour

{

    
    // Start is called before the first frame update
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(collision.gameObject);
           
        }
    }
}
