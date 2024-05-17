using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Alarm : MonoBehaviour
{
    public GameObject[] objectsToActivate; // Array de GameObjects que se activarán al entrar el jugador

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Asegúrate de que el otro objeto sea el jugador
        {
            ActivateObjects();
        }
    }

    void ActivateObjects()
    {
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null) // Asegúrate de que haya un GameObject para activar
            {
                obj.SetActive(true); // Activa el GameObject
            }
            else
            {
                Debug.LogWarning("Uno de los GameObjects a activar es nulo.");
            }
        }
    }
}
