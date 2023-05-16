using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryPause : MonoBehaviour
{ 
    public GameObject Inventory;
    public GameObject Camera;
    public GameObject CameraMov;
    public bool Paused = false;


    void Start()
    {
           Inventory.GetComponent<CanvasGroup>().alpha = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown("e") && Time.timeScale != 0.0f)
        {
            if (Paused == true)
            {
                Time.timeScale = 1.0f;
                Inventory.GetComponent<CanvasGroup>().alpha = 0;
                Cursor.lockState = CursorLockMode.Locked;
                CameraMov.gameObject.SetActive(true);
                Cursor.visible = false;
                Paused = false;
            }
            else
            {
                Time.timeScale = 0.0f;
                Inventory.GetComponent<CanvasGroup>().alpha = 1;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.lockState = CursorLockMode.None;
                CameraMov.gameObject.SetActive(false);
                Cursor.visible = true;
                Paused = true;
               
            }
        }
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        Inventory.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        CameraMov.gameObject.SetActive(true);
        Cursor.visible = false;
    }

}