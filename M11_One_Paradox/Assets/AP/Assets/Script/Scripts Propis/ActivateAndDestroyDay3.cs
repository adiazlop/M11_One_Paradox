using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAndDestroyDay3 : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToDestroy1;
    public GameObject objectToDestroy2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
            }
            else
            {
                Debug.LogWarning("No se ha asignado ningún GameObject para activar.");
            }

            if (objectToDestroy1 != null)
            {
                Destroy(objectToDestroy1);
            }
            else
            {
                Debug.LogWarning("No se ha asignado ningún primer GameObject para destruir.");
            }

            if (objectToDestroy2 != null)
            {
                Destroy(objectToDestroy2);
            }
            else
            {
                Debug.LogWarning("No se ha asignado ningún segundo GameObject para destruir.");
            }
        }
    }
}
