using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Canvas : MonoBehaviour
{
    public GameObject objectToActivate; // El GameObject que se activar� y luego se destruir�
    public float destructionDelay = 5f; // Tiempo en segundos antes de destruir el objeto

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Aseg�rate de que el otro objeto sea el jugador
        {
            if (objectToActivate != null) // Aseg�rate de que hay un objeto para activar
            {
                objectToActivate.SetActive(true); // Activa el GameObject
                Destroy(objectToActivate, destructionDelay); // Destruye el GameObject despu�s del tiempo especificado
            }
            else
            {
                Debug.LogWarning("No se ha asignado ning�n GameObject para activar y destruir.");
            }
        }
    }
}
