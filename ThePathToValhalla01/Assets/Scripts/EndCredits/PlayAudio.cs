using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private float volume;
    [SerializeField]
    private int startFadeOut;

    IEnumerator StartFade(float duration, float targetVolume)
    {
        float currentTime = 0;
        float start = audioSource.volume;
        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            yield return null;
        }
        yield break;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(startFadeOut);
        StartCoroutine(StartFade(3.0f, 0.0f));
    }

    void Start()
    {
        audioSource.volume = 0;
        StartCoroutine(StartFade(15.0f, 0.5f));
        StartCoroutine(Wait());
        audioSource.Play();
    }

    private void Update()
    {
        volume = audioSource.volume;
    }
}
