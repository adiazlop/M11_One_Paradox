using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log($"{gameObject.name} has been enabled by {new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().Name}");
        PauseGamePlay();
    }

    private void OnDisable()
    {
        ResumeGamePlay();
    }

    void PauseGamePlay()
    {
        Time.timeScale = 0f; // Pausar el tiempo en el juego
        // Aquí podrías pausar otros aspectos del juego según sea necesario
    }

    void ResumeGamePlay()
    {
        Time.timeScale = 1f; // Reanudar el tiempo en el juego
        // Aquí podrías reanudar otros aspectos del juego según sea necesario
    }
}
