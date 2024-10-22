using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class RotRotationgalteObject : MonoBehaviour
{
    // Public variable to control the spin speed, adjustable in the Inspector
    public float spinSpeed = 100f;

    void Update()
    {
        // Rotate the GameObject around its Y-axis (vertical spin) based on the spinSpeed
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
    }
}