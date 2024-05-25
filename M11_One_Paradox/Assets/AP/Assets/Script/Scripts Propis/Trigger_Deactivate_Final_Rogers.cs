using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Trigger_Deactivate_Final_Rogers : MonoBehaviour
{
    public Animator[] animatorsToDisable; // Array de componentes Animator a desactivar
    public NavMeshAgent[] navMeshAgentsToControl; // Array de componentes NavMeshAgent a modificar
    public GameObject[] gameObjectsEnd;
    public List<AudioSource> audioSourcesToDisable; // Lista de AudioSource a desactivar

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Desactivar los componentes Animator
            foreach (Animator animator in animatorsToDisable)
            {
                if (animator != null)
                {
                    animator.enabled = false;
                }
            }

            // Establecer la velocidad en 0 para los componentes NavMeshAgent
            foreach (NavMeshAgent navMeshAgent in navMeshAgentsToControl)
            {
                if (navMeshAgent != null)
                {
                    navMeshAgent.speed = 0;
                }
            }

            // Desactivar los componentes 
            foreach (GameObject gameObject in gameObjectsEnd)
            {
                if (gameObject != null)
                {
                    gameObject.SetActive(false); // Desactiva el GameObject
                }
            }

            // Desactivar los componentes AudioSource
            foreach (AudioSource audioSource in audioSourcesToDisable)
            {
                if (audioSource != null)
                {
                    audioSource.enabled = false; // Desactiva el AudioSource
                }
            }
        }
    }
}
