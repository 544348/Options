using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatiiongal : MonoBehaviour
{
    // The point around which the object will rotate (local to this object)
    public Transform pivotPoint;

    // Speed of the rotation
    public float rotationSpeed = 50f;

    void Update()
    {
        // Check if the pivot point is set
        if (pivotPoint != null)
        {
            // Rotate the object around the pivot's local position in the object's local space
            Vector3 localPivot = transform.TransformPoint(pivotPoint.localPosition);
            transform.RotateAround(localPivot, transform.up, rotationSpeed * Time.deltaTime);
        }
    }
}
