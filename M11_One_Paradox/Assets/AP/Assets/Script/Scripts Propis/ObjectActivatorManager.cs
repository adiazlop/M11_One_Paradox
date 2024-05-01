using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActivatorManager : MonoBehaviour
{
     public GameObject[] objectsToActivate; // Los 3 gameobjects que deben activarse
    public AudioClip activationSound; // El audio que se reproducirá cuando los objetos estén activados
    public Animator animatorToActivate; // El animator que se activará cuando los objetos estén activados

    private int activatedObjectsCount = 0; // Contador para llevar el registro de los objetos activados
    private AudioSource audioSource; // Referencia al componente AudioSource

    void Start()
    {
        // Obtener el componente AudioSource adjunto al gameobject
        audioSource = GetComponent<AudioSource>();
    }

    // Método para activar un objeto y verificar si se han activado todos
    public void ActivateObject(GameObject objectToActivate)
    {
        objectToActivate.SetActive(true); // Activar el objeto

        // Incrementar el contador de objetos activados
        activatedObjectsCount++;

        // Verificar si se han activado todos los objetos
        if (activatedObjectsCount >= objectsToActivate.Length)
        {
            // Reproducir el sonido de activación si se proporcionó un clip de audio
            if (activationSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(activationSound);
            }

            // Activar el animator si se proporcionó uno
            if (animatorToActivate != null)
            {
                animatorToActivate.enabled = true;
            }
        }
    }
}
