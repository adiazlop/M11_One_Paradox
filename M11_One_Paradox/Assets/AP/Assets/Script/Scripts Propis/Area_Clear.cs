using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Area_Clear : MonoBehaviour
{
    public GameObject[] objectsToDestroy; // Array de objetos que serán destruidos

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el jugador ha entrado en la zona
        {
            DestroyObjects();
        }
    }

    void DestroyObjects()
    {
        foreach (GameObject obj in objectsToDestroy)
        {
            if (obj != null)
            {
                Destroy(obj);
            }
        }
    }
}
