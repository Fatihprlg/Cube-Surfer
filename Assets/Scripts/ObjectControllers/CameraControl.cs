using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]
    GameObject target;

    [SerializeField]
    Vector3 distance;

    float camSpeed = 3;
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + distance, Time.deltaTime * camSpeed);
    }
}
