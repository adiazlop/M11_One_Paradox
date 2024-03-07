using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarScript : MonoBehaviour
{
    // M�todo para activar el GameObject
    public void ActivarObjeto()
    {
        // Verificar si el GameObject est� desactivado
        if (!gameObject.activeSelf)
        {
            // Activar el GameObject
            gameObject.SetActive(true);
        }
    }
}
