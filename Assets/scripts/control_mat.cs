using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_mat : MonoBehaviour
{

    
    Animator _anim;

    private bool Hactivo;
    private bool Vactivo;

    public AudioSource pasosMat;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
       
    }

   

    // Update is called once per frame
    void Update()
    {
        Movements();
        {
            float move = Input.GetAxis("Horizontal");

            bool walking = move != 0 ? true : false;

            _anim.SetBool("walking", walking);

        }

        if (Input.GetButtonDown("Horizontal"))
        {
            Hactivo = true;
            pasosMat.Play();
        }

        if (Input.GetButtonDown("Vertical"))
        {
            Vactivo = true;
            pasosMat.Play();
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            Hactivo = false;
            if(Vactivo == false)
            {
                pasosMat.Pause();
            }
        }

        if (Input.GetButtonUp("Vertical"))
        {
            Vactivo = false;
            if (Hactivo == false)
            {
                pasosMat.Pause();
            }
        
        }
    }

    void Movements()
    {
        // movimiento izquierda y derecha

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * 6f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * 6f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, -180);
        }

        
    }
}
