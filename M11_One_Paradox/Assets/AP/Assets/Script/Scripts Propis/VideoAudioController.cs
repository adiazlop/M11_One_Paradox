using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoAudioController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Referencia al VideoPlayer
    public GameObject[] gameObjectsToDeactivate; // Array de GameObjects a desactivar

    private AudioSource[] allAudioSources;
    private bool videoPlaying = false;

    private void Start()
    {
        if (videoPlayer == null)
        {
            videoPlayer = GetComponent<VideoPlayer>();
        }

        if (videoPlayer != null)
        {
            videoPlayer.started += OnVideoStarted;
            //videoPlayer.loopPointReached += OnVideoEnded; // Opcional: si deseas restaurar el audio después de que termine el video
        }
    }

    private void OnVideoStarted(VideoPlayer vp)
    {
        MuteAllAudioSourcesExceptVideo();
        DeactivateGameObjects();
    }

    private void OnVideoEnded(VideoPlayer vp)
    {
        RestoreAllAudioSources();
        ReactivateGameObjects();
    }

    private void MuteAllAudioSourcesExceptVideo()
    {
        allAudioSources = FindObjectsOfType<AudioSource>();

        foreach (AudioSource audioSource in allAudioSources)
        {
            if (audioSource != videoPlayer.GetTargetAudioSource(0)) // Suponiendo que el video player usa la primera pista de audio
            {
                audioSource.Pause();
            }
        }

        videoPlaying = true;
    }

    private void RestoreAllAudioSources()
    {
        if (videoPlaying)
        {
            foreach (AudioSource audioSource in allAudioSources)
            {
                if (audioSource != null && !audioSource.isPlaying)
                {
                    audioSource.UnPause();
                }
            }

            videoPlaying = false;
        }
    }

    private void DeactivateGameObjects()
    {
        foreach (GameObject go in gameObjectsToDeactivate)
        {
            if (go != null)
            {
                go.SetActive(false);
            }
        }
    }

    private void ReactivateGameObjects()
    {
        foreach (GameObject go in gameObjectsToDeactivate)
        {
            if (go != null)
            {
                go.SetActive(true);
            }
        }
    }

    private void OnDestroy()
    {
        if (videoPlayer != null)
        {
            videoPlayer.started -= OnVideoStarted;
            videoPlayer.loopPointReached -= OnVideoEnded;
        }
    }
}
