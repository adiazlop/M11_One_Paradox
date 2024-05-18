using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Canvas : MonoBehaviour
{
    public GameObject objectToActivate; // El GameObject que se activará y luego se destruirá
    public float destructionDelay = 5f; // Tiempo en segundos antes de destruir el objeto

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el otro objeto sea el jugador
        {
            if (objectToActivate != null) // Asegúrate de que hay un objeto para activar
            {
                objectToActivate.SetActive(true); // Activa el GameObject
                Destroy(objectToActivate, destructionDelay); // Destruye el GameObject después del tiempo especificado
            }
            else
            {
                Debug.LogWarning("No se ha asignado ningún GameObject para activar y destruir.");
            }
        }
    }
}
