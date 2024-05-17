using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CameraFocusTrigger : MonoBehaviour
{
    public Camera otherCamera; // Referencia a la cámara que quieres activar
    public MonoBehaviour componentToActivate; // Componente de script que quieres activar
    public GameObject[] gameObjectsToActivate; // Array de GameObjects que quieres activar
    public GameObject[] gameObjectsToDeactivate; // Array de GameObjects que quieres desactivar
    public float cameraActiveDuration = 43f; // Duración en segundos para mantener activada la cámara

    private bool cameraActive = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el objeto que entró en el collider es el jugador
        {
            // Activa la otra cámara si está disponible
            if (otherCamera != null && !cameraActive)
            {
                otherCamera.gameObject.SetActive(true);
                cameraActive = true;
                Invoke("DeactivateCamera", cameraActiveDuration); // Desactiva la cámara después de un tiempo
            }

            // Activa los GameObjects si están disponibles
            foreach (GameObject go in gameObjectsToActivate)
            {
                if (go != null)
                    go.SetActive(true);
            }

            // Desactiva los GameObjects si están disponibles
            foreach (GameObject go in gameObjectsToDeactivate)
            {
                if (go != null)
                    go.SetActive(false);
            }

            // Desactiva el componente si está disponible
            if (componentToActivate != null)
            {
                componentToActivate.enabled = false;
                Invoke("ActivateComponent", cameraActiveDuration); // Activa el componente después de un tiempo
            }
        }
    }

    void DeactivateCamera()
    {
        if (otherCamera != null)
        {
            otherCamera.gameObject.SetActive(false);
            cameraActive = false;

            // Desactiva los GameObjects si están disponibles
            foreach (GameObject go in gameObjectsToActivate)
            {
                if (go != null)
                    go.SetActive(false);
            }
        }
    }

    void ActivateComponent()
    {
        if (componentToActivate != null)
        {
            componentToActivate.enabled = true;
        }
    }
}
