using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area_Enable : MonoBehaviour
{
    public GameObject[] objectsToEnable; // Array de objetos que serán activados

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el jugador ha entrado en la zona
        {
            EnableObjects();
        }
    }

    void EnableObjects()
    {
        foreach (GameObject obj in objectsToEnable)
        {
            if (obj != null)
            {
                obj.SetActive(true); // activa el GameObject
            }
        }
    }
}
