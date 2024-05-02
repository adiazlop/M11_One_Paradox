using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeactivateOnTrigger : MonoBehaviour
{
    public GameObject objectToToggle; // El gameobject que se activará/desactivará
    public string playerTag = "Player"; // El tag del jugador

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que entra en el collider tiene el tag del jugador
        if (other.CompareTag(playerTag))
        {
            // Desactivar el gameobject
            if (objectToToggle != null)
            {
                objectToToggle.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Verificar si el objeto que sale del collider tiene el tag del jugador
        if (other.CompareTag(playerTag))
        {
            // Activar el gameobject
            if (objectToToggle != null)
            {
                objectToToggle.SetActive(true);
            }
        }
    }
}
