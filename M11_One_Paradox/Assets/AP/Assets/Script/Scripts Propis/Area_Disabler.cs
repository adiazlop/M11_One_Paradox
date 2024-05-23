using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area_Disabler : MonoBehaviour
{
    public GameObject[] objectsToDisable; // Array de objetos que ser�n desactivados

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el jugador ha entrado en la zona
        {
            DisableObjects();
        }
    }

    void DisableObjects()
    {
        foreach (GameObject obj in objectsToDisable)
        {
            if (obj != null)
            {
                obj.SetActive(false); // Desactiva el GameObject
            }
        }
    }
}
