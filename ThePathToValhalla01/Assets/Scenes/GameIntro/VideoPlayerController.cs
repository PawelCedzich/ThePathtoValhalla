using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private bool isVideoPlaying = true;

    private void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    private void Update()
    {
        if (isVideoPlaying && Input.GetKeyDown(KeyCode.Space))
        {
            SkipVideo();
        }
    }

    private void OnVideoEnd(VideoPlayer vp)
    {
        SkipVideo();
    }

    private void SkipVideo()
    {
        isVideoPlaying = false;
        SceneManager.LoadScene(1);
    }
}