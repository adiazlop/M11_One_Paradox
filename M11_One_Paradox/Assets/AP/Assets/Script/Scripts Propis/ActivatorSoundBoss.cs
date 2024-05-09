using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorSoundBoss : MonoBehaviour
{
    public string playerTag = "Player"; // Etiqueta del jugador
    public GameObject objectToActivate; // GameObject que se activar� al detectar al jugador

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag)) // Verifica si el objeto que entra en el trigger tiene la etiqueta del jugador
        {
            if (objectToActivate != null) // Verifica si el GameObject a activar es v�lido
            {
                objectToActivate.SetActive(true); // Activa el GameObject
            }
            else
            {
                Debug.LogWarning("El GameObject a activar no est� asignado en el inspector."); // Advertencia si el GameObject a activar no est� asignado
            }
        }
    }
}
