using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirofi : MonoBehaviour
{
    public static int llave;

    // Start is called before the first frame update
    private void Start()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        llave = 0;

        if (collision.gameObject.tag.Equals("key"))
        {
            llave += 1;
            Destroy(collision.gameObject);
        }

    }

}
