using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limite_camara : MonoBehaviour
{

    [SerializeField]
    private Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, -41f, 42f), Mathf.Clamp(target.position.y, 0, 0), transform.position.z);

    }
}
