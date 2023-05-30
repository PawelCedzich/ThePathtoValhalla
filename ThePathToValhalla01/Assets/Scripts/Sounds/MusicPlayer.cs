using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource audioSource;
    public float newClip;
    public float timer;
    public Slider volumeSlider;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        volumeSlider.onValueChanged.AddListener(OnVolumeSliderChanged);
        volumeSlider.value = 0.5f;
        newCLIP();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= newClip + 1)
        {
            if (!audioSource.isPlaying)
            {
                newCLIP();
                timer = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            SkipToNextClip();
        }
    }

    private void OnVolumeSliderChanged(float value)
    {
        audioSource.volume = value;
    }

    void newCLIP()
    {
        int clipNum = Random.Range(0, clips.Length);
        audioSource.clip = clips[clipNum];
        audioSource.loop = true;
        audioSource.Play();

        newClip = clips[clipNum].length;
    }

    void SkipToNextClip()
    {
        audioSource.Stop();
        newCLIP();
        timer = 0;
    }
}