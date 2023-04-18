using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pause : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Camera;
    public GameObject CameraMov;
    public GameObject InteractionCam;
    public GameObject PlayerHUD;
    public bool Paused = false;


    void Start()
    {
        PlayerHUD.gameObject.SetActive(true);
        Canvas.gameObject.SetActive(false);
        CameraMov.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (Paused == true)
            {
                Time.timeScale = 1.0f;
                Canvas.gameObject.SetActive(false);
                //Inventory.gameObject.SetActive(true);
                PlayerHUD.gameObject.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                InteractionCam.gameObject.SetActive(true);
                CameraMov.gameObject.SetActive(true);
                Cursor.visible = false;
                //Camera.GetComponent<AudioSource>().Play();
                Paused = false;
            }
            else
            {
                Time.timeScale = 0.0f;
                Canvas.gameObject.SetActive(true);
                //Inventory.gameObject.SetActive(false);
                PlayerHUD.gameObject.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                InteractionCam.gameObject.SetActive(false);
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
        //Inventory.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        InteractionCam.gameObject.SetActive(true);
        CameraMov.gameObject.SetActive(true);
        Cursor.visible = false;
        //Camera.GetComponent<AudioSource>().Play();
    }
}