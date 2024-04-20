using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acala_Flikering : MonoBehaviour
{
    public GameObject objectToToggle;

    void Start()
    {
        if (objectToToggle == null)
        {
            Debug.LogError("Por favor, asigna un GameObject para activar/desactivar en el inspector.");
            enabled = false;
            return;
        }

        StartCoroutine(ToggleObjectLoop());
    }

    IEnumerator ToggleObjectLoop()
    {
        while (true)
        {
            objectToToggle.SetActive(true);
            yield return new WaitForSeconds(1);
            objectToToggle.SetActive(false);
            yield return new WaitForSeconds(5);
        }
    }
}
