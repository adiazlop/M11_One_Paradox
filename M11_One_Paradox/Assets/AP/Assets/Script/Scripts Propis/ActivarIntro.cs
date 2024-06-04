using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarIntro : MonoBehaviour
{
    // Lista de GameObjects que se pueden asignar desde el editor
    [SerializeField] private GameObject[] objectsToActivate;

    // AudioSource cuyo volumen ser� modificado
    [SerializeField] private AudioSource audioSource;

    // Volumen original del AudioSource
    private float originalVolume;

    // Volumen reducido cuando los objetos est�n activos
    [SerializeField] private float reducedVolume = 0.2f;

    void Start()
    {
        if (audioSource != null)
        {
            // Guardar el volumen original
            originalVolume = audioSource.volume;
        }
    }

    // Esta funci�n recibe un array de GameObjects y los activa
    public void ActivateObjects(GameObject[] objectsToActivate)
    {
        foreach (GameObject obj in objectsToActivate)
        {
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }

        // Reducir el volumen del AudioSource
        if (audioSource != null)
        {
            audioSource.volume = reducedVolume;
        }
    }

    // Esta funci�n recibe un array de GameObjects y los desactiva
    public void DeactivateObjects(GameObject[] objectsToDeactivate)
    {
        foreach (GameObject obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }

        // Restaurar el volumen original del AudioSource
        if (audioSource != null)
        {
            audioSource.volume = originalVolume;
        }
    }

    // Sobrecarga del m�todo ActivateObjects que usa los objetos asignados en el Inspector
    public void ActivateAssignedObjects()
    {
        ActivateObjects(objectsToActivate);
    }

    // Sobrecarga del m�todo DeactivateObjects que usa los objetos asignados en el Inspector
    public void DeactivateAssignedObjects()
    {
        DeactivateObjects(objectsToActivate);
    }

    // M�todo para detectar la pulsaci�n de la tecla ESC y desactivar objetos
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) ||
            Input.GetKeyDown(KeyCode.Space) ||
            Input.GetKeyDown(KeyCode.Return) ||
            Input.GetKeyDown(KeyCode.Mouse0))
        {
            DeactivateAssignedObjects();
        }
    }
}
