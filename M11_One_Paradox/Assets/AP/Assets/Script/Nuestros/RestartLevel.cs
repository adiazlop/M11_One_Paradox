using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public Transform initialPlayerPosition; // Referencia al marcador de la posición inicial del jugador

    private void OnTriggerEnter(Collider other)
    {
        // Eliminar todos los datos persistentes
        PlayerPrefs.DeleteAll();
        // Recargar la escena actual desde cero
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Restablecer la posición del jugador al lugar inicial
        if (initialPlayerPosition != null)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                player.transform.position = initialPlayerPosition.position;
            }
        }
    }
}
