using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAnimatorDoor : MonoBehaviour
{
    public Animator animator; // El Animator que se activará o desactivará
    public bool activateAnimator = false; // La variable booleana que controla si se activa o desactiva el Animator

    // Método para activar o desactivar el Animator
    public void ToggleAnimator()
    {
        if (animator != null)
        {
            animator.enabled = activateAnimator;
        }
        else
        {
            Debug.LogWarning("Animator no asignado en el inspector.");
        }
    }

    // Método para activar el Animator
    public bool ActivateAnimator()
    {
        activateAnimator = true;
        ToggleAnimator();
        return true;
    }

}
