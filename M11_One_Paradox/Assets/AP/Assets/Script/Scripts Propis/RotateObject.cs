using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 30f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Rotar el objeto en su eje Y
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
