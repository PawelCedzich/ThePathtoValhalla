using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class OutroPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private bool isFading;

    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        StartCoroutine(FadeOutAudio());
        SceneManager.LoadScene(4);
    }

    private System.Collections.IEnumerator FadeOutAudio()
    {
        isFading = true;

        float elapsedTime = 0f;
        float fadeDuration = 1f;
        float startVolume = videoPlayer.GetDirectAudioVolume(0);
        float targetVolume = 0.5f;

        while (elapsedTime < fadeDuration)
        {
            float t = elapsedTime / fadeDuration;
            float currentVolume = Mathf.Lerp(startVolume, targetVolume, t);
            videoPlayer.SetDirectAudioVolume(0, currentVolume);

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        videoPlayer.SetDirectAudioVolume(0, targetVolume);
        isFading = false;
    }
}