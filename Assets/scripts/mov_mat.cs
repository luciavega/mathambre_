using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_mat : MonoBehaviour
{
    Rigidbody2D mat;
    Animator animator;

    Vector2 move;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
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
