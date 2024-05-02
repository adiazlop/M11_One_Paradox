using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public string playerTag = "Player"; // El tag del jugador
    public GameObject targetObject; // El GameObject que se destruirá cuando el jugador entre en el trigger

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que entra en el trigger tiene el tag del jugador
        if (other.CompareTag(playerTag))
        {
            // Verificar si el objeto que se debe destruir no es nulo
            if (targetObject != null)
            {
                // Destruir el GameObject especificado
                Destroy(targetObject);
            }
            else
            {
                Debug.LogWarning("El GameObject a destruir no está asignado.");
            }
        }
    }
}
