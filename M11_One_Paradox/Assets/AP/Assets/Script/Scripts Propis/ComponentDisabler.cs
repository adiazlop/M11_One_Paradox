using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentDisabler : MonoBehaviour
{
    public GameObject objectToDisable; // El GameObject que contiene el script que quieres desactivar

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el otro GameObject tiene el tag "Robot"
        if (other.CompareTag("Robot"))
        {
            // Verificar si el GameObject a desactivar está definido
            if (objectToDisable != null)
            {
                // Intentar encontrar el componente de script en el GameObject a desactivar
                MonoBehaviour scriptComponent = objectToDisable.GetComponent<MonoBehaviour>();

                // Si se encuentra el componente de script, desactivarlo
                if (scriptComponent != null)
                {
                    scriptComponent.enabled = false;
                    Debug.Log("Script desactivado en " + objectToDisable.name);
                }
                else
                {
                    Debug.LogWarning("No se encontró un componente de script en " + objectToDisable.name);
                }
            }
            else
            {
                Debug.LogWarning("El GameObject a desactivar no está asignado.");
            }
        }
    }
}
