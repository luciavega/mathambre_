using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ARDUINO
// using System.IO.Ports;

public class mov_mat : MonoBehaviour
{
  
    Rigidbody2D mat;
    Animator animator;

    Vector2 move;
    public float velocidad;

    // ARDUINO
    // VER PUERTO AL CUAL ESTA CONECTADO EL ARDUINO
    // public SerialPort puerto = new SerialPort("COM4", 9600);

    void Start()
    {
        // ARDUINO
        // puerto.ReadTimeout = 30;
        // puerto.Open();
        mat = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // ARDUINO
        /* try { 
          if (puerto.IsOpen)
          {
              string dato_recibido = puerto.ReadLine();
              Debug.Log(dato_recibido);
          }
         }catch(System.Exception ex1)
         {
             ex1 = new System.Exception();
         }
        */

        move = new Vector2();
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");

        if (move != Vector2.zero)
        {
            animator.SetFloat("Movimiento X", move.x);
            animator.SetFloat("Movimiento Y", move.y);
            animator.SetBool("Moviendo", true);
        }
        else
        {
            animator.SetBool("Moviendo", false);
        }

        mat.MovePosition(transform.position + (Vector3)move * Time.deltaTime * velocidad);


    }

    
}
