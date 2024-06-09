using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subt_Activator_Final : MonoBehaviour
{
    // Objeto que se activar�
    public GameObject objectToActivate;

    // M�todo que activar� el objeto
    public void ActivateObject()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }
        else
        {
            Debug.LogWarning("No se ha asignado ning�n objeto para activar.");
        }
    }
}
