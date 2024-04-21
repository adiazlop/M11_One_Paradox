using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAndDestroyDay2 : MonoBehaviour
{
    public GameObject objectToActivate;
    public GameObject objectToDestroy;

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

            if (objectToDestroy != null)
            {
                Destroy(objectToDestroy);
            }
            else
            {
                Debug.LogWarning("No se ha asignado ningún GameObject para destruir.");
            }
        }
    }
}
