using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_1080 : MonoBehaviour
{
    public GameObject objectToActivate; // El GameObject que se activará y desactivará
    public string playerTag = "Player"; // La etiqueta del jugador, ajustable en el editor

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag)) // Verifica si el objeto que entra tiene la etiqueta del jugador
        {
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true); // Activa el GameObject
            }
            else
            {
                Debug.LogWarning("No se ha asignado ningún GameObject para activar.");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(playerTag)) // Verifica si el objeto que sale tiene la etiqueta del jugador
        {
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(false); // Desactiva el GameObject
            }
            else
            {
                Debug.LogWarning("No se ha asignado ningún GameObject para desactivar.");
            }
        }
    }
}
