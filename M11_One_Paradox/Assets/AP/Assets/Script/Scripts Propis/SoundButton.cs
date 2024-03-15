using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public AudioClip soundClip;  // Clip de audio para reproducir
    private AudioSource audioSource;  // Referencia al componente AudioSource

    // Método para alternar entre reproducir y detener el sonido
    public bool ToggleSound()
    {
        // Verificar si el clip de audio está asignado
        if (soundClip == null)
        {
            Debug.LogWarning("No se ha asignado un clip de audio para reproducir.");
            return false;
        }

        // Obtener o agregar el componente AudioSource al objeto actual
        if (audioSource == null)
        {
            audioSource = gameObject.GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
        }

        // Alternar entre reproducir y detener el sonido
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.clip = soundClip;
            audioSource.Play();
            Debug.Log("Clip de audio reproducido: " + soundClip.name);
        }

        return true;
    }
}
