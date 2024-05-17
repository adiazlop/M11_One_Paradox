using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Canvas : MonoBehaviour
{
    public GameObject objectToActivate; // El GameObject que se activará y luego se destruirá

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el otro objeto sea el jugador
        {
            if (objectToActivate != null) // Asegúrate de que hay un objeto para activar
            {
                objectToActivate.SetActive(true); // Activa el GameObject
                Destroy(objectToActivate, 5f); // Destruye el GameObject después de 5 segundos
            }
            else
            {
                Debug.LogWarning("No se ha asignado ningún GameObject para activar y destruir.");
            }
        }
    }
}
