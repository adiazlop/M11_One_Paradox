using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollowCanvasHud : MonoBehaviour
{
    public Transform playerCamera; // La c�mara del jugador que queremos seguir
    public Canvas canvas; // El Canvas que queremos ajustar
    public Vector3 offset = new Vector3(0, 0, 2); // Desplazamiento relativo al jugador
    public float smoothSpeed = 10f; // La velocidad de interpolaci�n, m�s alta para un seguimiento m�s r�pido
    public float maxDistance = 5f; // La distancia m�xima del canvas respecto al jugador

    private Vector3 initialPosition;

    void Start()
    {
        if (canvas == null)
        {
            canvas = GetComponent<Canvas>();
        }

        // Asegurarse de que el canvas est� en modo World Space
        if (canvas.renderMode != RenderMode.WorldSpace)
        {
            Debug.LogWarning("El Canvas debe estar en modo World Space");
            canvas.renderMode = RenderMode.WorldSpace;
        }

        // Guardar la posici�n inicial del canvas
        initialPosition = canvas.transform.position;
    }

    void LateUpdate()
    {
        if (playerCamera != null)
        {
            // Calcular la posici�n objetivo con el offset
            Vector3 targetPosition = playerCamera.position + playerCamera.forward * offset.z + playerCamera.right * offset.x + playerCamera.up * offset.y;

            // Limitar la distancia del canvas respecto al jugador
            Vector3 directionToPlayer = targetPosition - playerCamera.position;
            float distanceToPlayer = directionToPlayer.magnitude;
            if (distanceToPlayer > maxDistance)
            {
                targetPosition = playerCamera.position + directionToPlayer.normalized * maxDistance;
            }

            // Interpolar suavemente la posici�n del canvas hacia la posici�n objetivo
            Vector3 smoothedPosition = Vector3.Lerp(canvas.transform.position, targetPosition, smoothSpeed * Time.deltaTime);

            // Actualizar la posici�n del canvas
            canvas.transform.position = smoothedPosition;

            // Asegurar que el Canvas siempre mire hacia la c�mara
            canvas.transform.rotation = Quaternion.LookRotation(canvas.transform.position - playerCamera.position);
        }
    }

}
