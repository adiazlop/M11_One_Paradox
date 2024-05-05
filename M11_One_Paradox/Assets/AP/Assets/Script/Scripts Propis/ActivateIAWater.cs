using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateIAWater : MonoBehaviour
{
    public GameObject[] objectsToActivate; // Los 3 GameObjects que se activarán cuando el jugador entre en el collider

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el otro GameObject tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Activar todos los GameObjects en la lista
            foreach (GameObject obj in objectsToActivate)
            {
                obj.SetActive(true);
            }
        }
    }
}
