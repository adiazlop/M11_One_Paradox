using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectZ : MonoBehaviour
{
    public float rotationSpeed = 30f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Rotar el objeto en su eje Y
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
