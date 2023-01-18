using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform targetObject;
    public float smoothSpeed = 0.5f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetObject.position, smoothSpeed * Time.deltaTime);        
    }
}
