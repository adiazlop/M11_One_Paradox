using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class IA_Enemy : MonoBehaviour
{
    [SerializeField] private Transform[] patrolPoints;
    [SerializeField] private float chaseRange = 10f;
    private NavMeshAgent agent;
    private Transform player;
    private int currentPatrolIndex = 0;
    private Vector3 initialPosition; // Posición inicial del enemigo

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        if (patrolPoints.Length < 2)
        {
            Debug.LogError("Se requieren al menos dos puntos de patrulla para patrullar.");
            enabled = false;
            return;
        }

        initialPosition = transform.position;
        SetDestinationToNextPatrolPoint();
    }

    void Update()
    {
        // Verificar si el jugador sigue existiendo
        if (player != null)
        {
            if (Vector3.Distance(transform.position, player.position) <= chaseRange)
            {
                agent.SetDestination(player.position);
            }
            else if (agent.remainingDistance < 0.1f && !agent.pathPending)
            {
                SetDestinationToNextPatrolPoint();
            }
        }
    }

    void SetDestinationToNextPatrolPoint()
    {
        agent.SetDestination(patrolPoints[currentPatrolIndex].position);
        currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
