using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private void OnEnable()
    {
        PauseGamePlay();
    }

    private void OnDisable()
    {
        ResumeGamePlay();
    }

    void PauseGamePlay()
    {
        Time.timeScale = 0f; // Pausar el tiempo en el juego
        // Aqu� podr�as pausar otros aspectos del juego seg�n sea necesario
    }

    void ResumeGamePlay()
    {
        Time.timeScale = 1f; // Reanudar el tiempo en el juego
        // Aqu� podr�as reanudar otros aspectos del juego seg�n sea necesario
    }
}
