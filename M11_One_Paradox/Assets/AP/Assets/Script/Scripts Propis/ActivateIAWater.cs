using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateIAWater : MonoBehaviour
{
    // Arrays de GameObjects que se activarán después de diferentes tiempos
    public GameObject[] objectsToActivateAfterDelay1;
    public float delay1 = 1f;

    public GameObject[] objectsToActivateAfterDelay2;
    public float delay2 = 2f;

    private bool playerEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si el otro GameObject tiene el tag "Player"
        if (other.CompareTag("Player") && !playerEntered)
        {
            playerEntered = true;
            StartCoroutine(ActivateObjectsAfterDelay(objectsToActivateAfterDelay1, delay1));
            StartCoroutine(ActivateObjectsAfterDelay(objectsToActivateAfterDelay2, delay2));
        }
    }

    private IEnumerator ActivateObjectsAfterDelay(GameObject[] objects, float delay)
    {
        yield return new WaitForSeconds(delay);
        // Activar todos los GameObjects en la lista
        foreach (GameObject obj in objects)
        {
            if (obj != null)
                obj.SetActive(true);
        }
    }
}
