using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            // Calcula la dirección hacia el jugador en el eje Y
            Vector3 direction = player.position - transform.position;
            direction.y = 0f; // Mantén la dirección en el eje Y

            // Rotación para mirar hacia el jugador en el eje Y
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            // Aplica la rotación, manteniendo los ejes X y Z actuales
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, targetRotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        }
    }
}
