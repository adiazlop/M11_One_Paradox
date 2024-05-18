using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMainMenu : MonoBehaviour
{
    public backInputs backInputs; // Referencia al script BackInputs

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (backInputs != null)
            {
                backInputs.MainMenuIngame();
            }
            else
            {
                Debug.LogWarning("BackInputs script is not assigned in the inspector.");
            }
        }
    }
}
