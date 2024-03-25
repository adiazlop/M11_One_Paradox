using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAnimator : MonoBehaviour
{
    public Animator targetAnimator;  // Referencia al Animator que se activará

    private void OnEnable()
    {
        // Verificar si se ha asignado un Animator
        if (targetAnimator == null)
        {
            Debug.LogWarning("No se ha asignado un Animator para activar.");
            return;
        }

        // Activar el Animator
        targetAnimator.enabled = true;
    }
}
