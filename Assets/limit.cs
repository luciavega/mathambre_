using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limit_cam : MonoBehaviour
{

    [SerializeField]
    private Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(targetToFollow.position.x, -32f, 32f), Mathf.Clamp(targetToFollow.position.y, 0, 0), transform.position.z);

    }
}
