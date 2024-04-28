using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorGravityController : MonoBehaviour
{
    public AudioClip floorSoundClip; // El clip de audio que se reproducirá al entrar el jugador
    void OnTriggerEnter(Collider other)
    {
        // Verificar si el objeto que entra tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Activar la gravedad en los hijos con Rigidbody
            Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();
            foreach (Rigidbody rb in rigidbodies)
            {
                rb.useGravity = true;
                rb.isKinematic = false;
            }
            // Reproducir el clip de audio en el AudioSource del objeto Floor
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null && floorSoundClip != null)
            {
                audioSource.clip = floorSoundClip;
                audioSource.Play();
            }
        }
    }
}
