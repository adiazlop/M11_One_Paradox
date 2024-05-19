using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollowCanvasHud : MonoBehaviour
{
    public Transform playerCamera; // La cámara del jugador que queremos seguir
    public Canvas canvas; // El Canvas que queremos ajustar
    public Vector3 offset = new Vector3(0, 0, 2); // Desplazamiento relativo al jugador
    public float lerpSpeed = 10f; // La velocidad de interpolación, más alta para un seguimiento más rápido

    private Vector3 initialPosition;

    void Start()
    {
        if (canvas == null)
        {
            canvas = GetComponent<Canvas>();
        }

        // Asegurarse de que el canvas está en modo World Space
        if (canvas.renderMode != RenderMode.WorldSpace)
        {
            Debug.LogWarning("El Canvas debe estar en modo World Space");
            canvas.renderMode = RenderMode.WorldSpace;
        }

        // Guardar la posición inicial del canvas
        initialPosition = canvas.transform.position;
    }

    void LateUpdate()
    {
        if (playerCamera != null)
        {
            // Calcular la posición objetivo con el offset
            Vector3 targetPosition = playerCamera.position + playerCamera.forward * offset.z + playerCamera.right * offset.x + playerCamera.up * offset.y;

            // Interpolar suavemente la posición del canvas hacia la posición objetivo
            canvas.transform.position = Vector3.Lerp(canvas.transform.position, targetPosition, lerpSpeed * Time.deltaTime);

            // Asegurar que el Canvas siempre mire hacia la cámara
            canvas.transform.rotation = Quaternion.LookRotation(canvas.transform.position - playerCamera.position);
        }
    }
}
