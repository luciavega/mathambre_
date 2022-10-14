using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_camara : MonoBehaviour
{
    public Transform MatTransform;
    public Vector3 deviation;
    void Start()
    {
        deviation = transform.position - MatTransform.position;
    }

    void Update()
    {
        transform.position = MatTransform.position + deviation;
    }
}
