using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private inventario inventario;
    public GameObject itemButton;

    private void Start()
    {
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<inventario>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventario.slots.Length; i++)
            {
                if (inventario.isFull[i] == false)
                {
                    // el item puede ser agregado al inventario
                    inventario.isFull[i] = true;
                    Instantiate(itemButton, inventario.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }

    private void OnMouseDown()
    {
        for (int i = 0; i < inventario.slots.Length; i++)
        {
            if (inventario.isFull[i] == false)
            {
                // el item puede ser agregado al inventario
                inventario.isFull[i] = true;
                Instantiate(itemButton, inventario.slots[i].transform);
                Destroy(gameObject);
                break;
            }
        }
    }
}
