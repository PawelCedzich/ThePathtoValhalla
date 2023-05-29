using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void PlaySound(string soundPath, float volume = 1.0f, float delay = 0.0f)
    {
        StartCoroutine(PlayDelayedSound(soundPath, volume, delay));
    }

    private System.Collections.IEnumerator PlayDelayedSound(string soundPath, float volume, float delay)
    {
        yield return new WaitForSeconds(delay);

        string fullPath = "Sounds/" + soundPath;
        AudioClip audioClip = Resources.Load<AudioClip>(fullPath);

        if (audioClip != null)
        {
            audioSource.PlayOneShot(audioClip, volume);
        }
        else
        {
            Debug.LogError("Sound clip not found: " + fullPath);
        }
    }
}