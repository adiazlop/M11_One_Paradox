using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnMove : MonoBehaviour
{
    public GameObject objectToDestroy;

    private Vector3 lastPosition;

    private void Start()
    {
        // Almacena la posición inicial
        lastPosition = transform.position;
    }

    private void Update()
    {
        // Comprueba si el GameObject sigue existiendo
        if (gameObject != null)
        {
            // Comprueba si la posición actual es diferente a la última posición registrada
            if (transform.position != lastPosition)
            {
                // Si ha cambiado la posición, destruye el GameObject
                Destroy(gameObject);

                // Comprueba si se ha asignado un GameObject para destruir
                if (objectToDestroy != null)
                {
                    // Destruye el GameObject especificado
                    Destroy(objectToDestroy);
                }
            }

            // Actualiza la última posición
            lastPosition = transform.position;
        }
    }
}
