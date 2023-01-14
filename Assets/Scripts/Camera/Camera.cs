using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // The object that the camera should follow
    public float smoothSpeed = 0.125f; // The speed at which the camera moves
    public Vector3 offset; // The distance between the camera and the target

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;        
        // Rotate the camera to match the rotation of the sphere

        transform.rotation = target.rotation;
    }
}
