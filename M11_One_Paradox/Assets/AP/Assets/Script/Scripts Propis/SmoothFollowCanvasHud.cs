using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollowCanvasHud : MonoBehaviour
{
    public RectTransform hudElement; // El RectTransform del elemento del HUD

    public Vector3 activeScale = new Vector3(1.1f, 1.1f, 1.1f); // La escala cuando el ratón se mueve
    public float smoothSpeed = 5f; // La velocidad de interpolación para el escalado
    public float returnSpeed = 5f; // La velocidad a la que el HUD vuelve a su escala original

    private Vector3 originalScale;
    private Vector3 targetScale;
    private bool isMouseMoving;

    void Start()
    {
        if (hudElement == null)
        {
            Debug.LogError("No HUD element assigned!");
            return;
        }

        // Guardar la escala original del HUD
        originalScale = hudElement.localScale;
    }

    void Update()
    {
        // Verificar el movimiento del ratón
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Si el ratón se está moviendo, escalar el HUD
        if (Mathf.Abs(mouseX) > 0.01f || Mathf.Abs(mouseY) > 0.01f)
        {
            isMouseMoving = true;
        }
        else
        {
            isMouseMoving = false;
        }

        // Determinar la escala objetivo
        targetScale = isMouseMoving ? activeScale : originalScale;

        // Interpolar suavemente hacia la escala objetivo
        float speed = isMouseMoving ? smoothSpeed : returnSpeed;
        hudElement.localScale = Vector3.Lerp(hudElement.localScale, targetScale, Time.deltaTime * speed);
    }
}
