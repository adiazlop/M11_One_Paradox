using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PlaySound_StopPlayer_Vignette : MonoBehaviour
{
    private AudioSource audioSource;
    public float vignetteDuration = 3f; // Duraci�n en segundos del efecto vignette
    public float delayBeforeVignetteActivation = 1f; // Retardo antes de activar el efecto vignette
    public MonoBehaviour playerScriptToDisable; // Script del jugador que se desactivar� durante el efecto vignette

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Puedes ajustar la etiqueta seg�n tus necesidades
        {
            audioSource.Play();

            // Desactiva el script del jugador temporalmente
            if (playerScriptToDisable != null)
            {
                playerScriptToDisable.enabled = false;
            }

            // Activa el efecto vignette despu�s de un retraso
            Invoke("EnableVignetteEffect", delayBeforeVignetteActivation);

            // Desactiva el efecto vignette despu�s de vignetteDuration segundos
            Invoke("DisableVignetteEffect", delayBeforeVignetteActivation + vignetteDuration);
        }
    }

    private void EnableVignetteEffect()
    {
        // Activa el efecto vignette
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            PostProcessVolume postProcessVolume = mainCamera.GetComponent<PostProcessVolume>();
            if (postProcessVolume != null)
            {
                Vignette vignette;
                if (postProcessVolume.profile.TryGetSettings(out vignette))
                {
                    vignette.enabled.value = true; // Activa el efecto vignette
                }
            }
        }
    }

    private void DisableVignetteEffect()
    {
        // Desactiva el efecto vignette
        Camera mainCamera = Camera.main;
        if (mainCamera != null)
        {
            PostProcessVolume postProcessVolume = mainCamera.GetComponent<PostProcessVolume>();
            if (postProcessVolume != null)
            {
                Vignette vignette;
                if (postProcessVolume.profile.TryGetSettings(out vignette))
                {
                    vignette.enabled.value = false; // Desactiva el efecto vignette
                }
            }
        }

        // Reactiva el script del jugador
        if (playerScriptToDisable != null)
        {
            playerScriptToDisable.enabled = true;
        }
    }
}
