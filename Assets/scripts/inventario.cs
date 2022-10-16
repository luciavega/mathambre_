using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum itemType
{
    none,
    linterna,
    camara,
    recorte
}
public class inventario : MonoBehaviour
{
    public static inventario instance;
    public Item[] items;
    private void Awake()
    {
        instance = this;  
    }

    public void EmptyStlo()
    {

    }
}
 [System.Serializable]
 public class Item
{
    public bool isFull;
    public int amount;
    public itemType type;
    public string name;
    public GameObject slotSprite;
}