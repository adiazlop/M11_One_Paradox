using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Initial_amnimator_text : MonoBehaviour
{
    public GameObject objectToActivate;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) // Puedes ajustar la etiqueta seg�n tus necesidades
        {
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
            }
            else
            {
                Debug.LogWarning("No se ha asignado ning�n GameObject para activar.");
            }
        }
    }
}
