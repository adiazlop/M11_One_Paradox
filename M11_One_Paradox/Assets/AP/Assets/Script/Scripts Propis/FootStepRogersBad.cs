using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepRogersBad : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al AudioSource que reproduce el sonido de los pasos

    public void PlayFootstepSound()
    {
        // Reproduce el sonido de los pasos
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
