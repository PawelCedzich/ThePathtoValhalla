using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryPause : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Camera;
    public GameObject CameraMov;
    public GameObject PlayerHUD;
    public bool Paused = false;


    void Start()
    {
        PlayerHUD.gameObject.SetActive(true);
        Canvas.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (Paused == true)
            {
                Time.timeScale = 1.0f;
                Canvas.gameObject.SetActive(false);
                PlayerHUD.gameObject.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                CameraMov.gameObject.SetActive(true);
                Cursor.visible = false;
                //Camera.GetComponent<AudioSource>().Play();
                Paused = false;
            }
            else
            {
                Time.timeScale = 0.0f;
                Canvas.gameObject.SetActive(true);
                PlayerHUD.gameObject.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.lockState = CursorLockMode.None;
                CameraMov.gameObject.SetActive(false);
                Cursor.visible = true;
                //Camera.GetComponent<AudioSource>().Pause();
                Paused = true;
            }
        }
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        Canvas.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        CameraMov.gameObject.SetActive(true);
        Cursor.visible = false;
        //Camera.GetComponent<AudioSource>().Play();
    }
}