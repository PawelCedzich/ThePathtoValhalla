using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PauseResume : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject CameraMov;

    public void Resume()
    {
        Time.timeScale = 1.0f;
        Canvas.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        CameraMov.gameObject.SetActive(true);
        Cursor.visible = false;
    }
}