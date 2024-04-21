using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSoundAREA : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public float maxVolume = 1f;
    public float fadeSpeed = 0.5f;

    private bool playerInside = false;
    private bool isFirstTime = true;

    void Start()
    {
        // Establecer el volumen inicialmente a cero
        videoPlayer.SetDirectAudioVolume(0, 0f);
    }

    void Update()
    {
        if (playerInside)
        {
            // Incrementar gradualmente el volumen cuando el jugador está dentro del área
            videoPlayer.SetDirectAudioVolume(0, Mathf.MoveTowards(videoPlayer.GetDirectAudioVolume(0), maxVolume, fadeSpeed * Time.deltaTime));
        }
        else if (!isFirstTime)
        {
            // Disminuir gradualmente el volumen cuando el jugador está fuera del área, excepto la primera vez
            videoPlayer.SetDirectAudioVolume(0, Mathf.MoveTowards(videoPlayer.GetDirectAudioVolume(0), 0f, fadeSpeed * Time.deltaTime));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            isFirstTime = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
        }
    }
}
