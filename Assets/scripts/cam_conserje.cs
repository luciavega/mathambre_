using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_conserje : MonoBehaviour
{

    [SerializeField]
    private Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(target.position.x, -3.12f, 0f), Mathf.Clamp(target.position.y, 0.4f, 0f), transform.position.z);

    }
}
