using UnityEngine;
using TMPro;

public class SkipText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float delay = 3f;
    public float duration = 5f;

    private void Start()
    {
        text.gameObject.SetActive(false);
        Invoke("ShowText", delay);
        Invoke("DestroyText", delay + duration);
    }

    private void ShowText()
    {
        text.gameObject.SetActive(true);
    }

    private void DestroyText()
    {
        Destroy(text.gameObject);
    }
}