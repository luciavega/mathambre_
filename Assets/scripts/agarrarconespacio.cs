using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agarrarconespacio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D col)
    {
        if (gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                Destroy(gameObject);
            }

        }
    }
}