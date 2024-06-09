using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subt_Activator_Final : MonoBehaviour
{
    public GameObject objectToMove;
    // Objeto que se activar�
    public GameObject objectToActivate;
    // Componente Image que se desactivar�
    public Image imageToDeactivate;

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

    // M�todo que desactivar� el componente Image
    public void DeactivateImage()
    {
        if (imageToDeactivate != null)
        {
            imageToDeactivate.enabled = false;
        }
        else
        {
            Debug.LogWarning("No se ha asignado ning�n componente Image para desactivar.");
        }
    }

    // M�todo que mover� el GameObject -3.0 en x
    public void MoveObject(GameObject objToMove)
    {
        if (objToMove != null)
        {
            Vector3 currentPosition = objToMove.transform.position;
            currentPosition.x += -2.0f;
            objToMove.transform.position = currentPosition;
        }
        else
        {
            Debug.LogWarning("No se ha asignado ning�n objeto para mover.");
        }
    }

}
