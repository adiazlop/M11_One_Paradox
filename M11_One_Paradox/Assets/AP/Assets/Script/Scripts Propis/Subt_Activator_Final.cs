using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subt_Activator_Final : MonoBehaviour
{
    public GameObject objectToMove;
    // Objeto que se activará
    public GameObject objectToActivate;
    // Componente Image que se desactivará
    public Image imageToDeactivate;

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

    // Método que desactivará el componente Image
    public void DeactivateImage()
    {
        if (imageToDeactivate != null)
        {
            imageToDeactivate.enabled = false;
        }
        else
        {
            Debug.LogWarning("No se ha asignado ningún componente Image para desactivar.");
        }
    }

    // Método que moverá el GameObject -3.0 en x
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
            Debug.LogWarning("No se ha asignado ningún objeto para mover.");
        }
    }

}
