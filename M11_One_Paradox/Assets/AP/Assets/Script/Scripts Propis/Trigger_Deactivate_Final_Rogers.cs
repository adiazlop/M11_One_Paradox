using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Trigger_Deactivate_Final_Rogers : MonoBehaviour
{
    public Animator[] animatorsToDisable; // Array de componentes Animator a desactivar
    public NavMeshAgent[] navMeshAgentsToControl; // Array de componentes NavMeshAgent a modificar

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
        }
    }
}
