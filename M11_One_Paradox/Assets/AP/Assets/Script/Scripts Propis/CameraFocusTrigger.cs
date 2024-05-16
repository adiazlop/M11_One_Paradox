using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CameraFocusTrigger : MonoBehaviour
{
    public GameObject[] gameObjectsToActivate; // Array de GameObjects que quieres activar
    public float activationDuration = 43f; // Duración en segundos para mantener activados los GameObjects
    public Animator animatorToActivate; // Animator que quieres activar después del tiempo especificado
    public AudioClip soundToPlay; // Sonido que quieres reproducir después del tiempo especificado

    private bool objectsActivated = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el objeto que entró en el collider es el jugador
        {
            // Activa los GameObjects si están disponibles
            if (!objectsActivated)
            {
                ActivateObjects();
                Invoke("DeactivateObjects", activationDuration); // Desactiva los GameObjects después de un tiempo
                Invoke("ActivateAnimator", activationDuration); // Activa el Animator después del tiempo
                Invoke("PlaySound", activationDuration); // Reproduce el sonido después del tiempo
            }
        }
    }

    void ActivateObjects()
    {
        foreach (GameObject go in gameObjectsToActivate)
        {
            if (go != null)
                go.SetActive(true);
        }

        objectsActivated = true;
    }

    void DeactivateObjects()
    {
        // Desactiva los GameObjects si están disponibles
        foreach (GameObject go in gameObjectsToActivate)
        {
            if (go != null)
                go.SetActive(false);
        }

        objectsActivated = false;
    }

    void ActivateAnimator()
    {
        if (animatorToActivate != null)
        {
            animatorToActivate.enabled = true;
            animatorToActivate.Play("barrera"); // Reemplaza "YourAnimationName" por el nombre de tu animación
        }
    }

    void PlaySound()
    {
        if (soundToPlay != null)
        {
            AudioSource.PlayClipAtPoint(soundToPlay, transform.position);
        }
    }
}
