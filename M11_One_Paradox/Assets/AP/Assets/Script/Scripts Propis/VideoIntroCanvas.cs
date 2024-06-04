using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoIntroCanvas : MonoBehaviour
{
    public VideoClip videoClip;

    void Start()
    {
        // Crear y configurar el Canvas
        GameObject canvasGO = new GameObject("VideoCanvas");
        Canvas canvas = canvasGO.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvasGO.AddComponent<CanvasScaler>();
        canvasGO.AddComponent<GraphicRaycaster>();

        // Crear y configurar la Raw Image
        GameObject rawImageGO = new GameObject("VideoRawImage");
        rawImageGO.transform.SetParent(canvasGO.transform);
        RawImage rawImage = rawImageGO.AddComponent<RawImage>();
        RectTransform rectTransform = rawImageGO.GetComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(0, 0);
        rectTransform.anchorMax = new Vector2(1, 1);
        rectTransform.offsetMin = new Vector2(0, 0);
        rectTransform.offsetMax = new Vector2(0, 0);

        // Crear y configurar la Render Texture
        RenderTexture renderTexture = new RenderTexture(1920, 1080, 16);
        renderTexture.Create();

        // Configurar la Raw Image para usar la Render Texture
        rawImage.texture = renderTexture;

        // Crear y configurar el Video Player
        GameObject videoPlayerGO = new GameObject("VideoPlayer");
        VideoPlayer videoPlayer = videoPlayerGO.AddComponent<VideoPlayer>();
        videoPlayer.renderMode = VideoRenderMode.RenderTexture;
        videoPlayer.targetTexture = renderTexture;
        videoPlayer.clip = videoClip;

        // Suscribirse al evento loopPointReached para detectar cuando el video termine
        videoPlayer.loopPointReached += EndReached;

        // Iniciar la reproducción del video
        videoPlayer.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("01_MainMenu");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("01_MainMenu");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("01_MainMenu");
        }
    }

    // Método para manejar el evento cuando el video termina
    void EndReached(VideoPlayer vp)
    {
        SceneManager.LoadScene("01_MainMenu");
    }
}
