using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    private float zPos = -10.0f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(transform.position.x, target.position.y + 3f, zPos);

        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);
    }
}
