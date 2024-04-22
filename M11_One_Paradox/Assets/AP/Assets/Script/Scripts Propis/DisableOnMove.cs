using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnMove : MonoBehaviour
{
    public GameObject objectToDestroy;

    private Vector3 lastPosition;

    private void Start()
    {
        // Almacena la posici�n inicial
        lastPosition = transform.position;
    }

    private void Update()
    {
        // Comprueba si el GameObject sigue existiendo
        if (gameObject != null)
        {
            // Comprueba si la posici�n actual es diferente a la �ltima posici�n registrada
            if (transform.position != lastPosition)
            {
                // Si ha cambiado la posici�n, destruye el GameObject
                Destroy(gameObject);

                // Comprueba si se ha asignado un GameObject para destruir
                if (objectToDestroy != null)
                {
                    // Destruye el GameObject especificado
                    Destroy(objectToDestroy);
                }
            }

            // Actualiza la �ltima posici�n
            lastPosition = transform.position;
        }
    }
}
