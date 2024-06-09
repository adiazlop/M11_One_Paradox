using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subt_Activator_Final : MonoBehaviour
{
    // Objeto que se activará
    public GameObject objectToActivate;

    // Método que activará el objeto
    public void ActivateObject()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }
        else
        {
            Debug.LogWarning("No se ha asignado ningún objeto para activar.");
        }
    }
}
