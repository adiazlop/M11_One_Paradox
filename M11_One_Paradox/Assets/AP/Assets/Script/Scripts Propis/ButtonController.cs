using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    // Método para alternar entre activar y desactivar el GameObject y devolver true
    public bool ToggleGameObject()
    {
        gameObject.SetActive(!gameObject.activeSelf);
        Debug.Log("GameObject toggled: " + gameObject.name);
        return true;
    }
}
