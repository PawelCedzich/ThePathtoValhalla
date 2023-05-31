using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public GameObject playerInventory;
    public GameObject chestInventory;

    public void Start(){
        chestInventory.GetComponent<CanvasGroup>().alpha = 0;
    }

    public void Interact()
    {
        Time.timeScale = 0.0f;
        playerInventory.GetComponent<CanvasGroup>().alpha = 1;
        chestInventory.GetComponent<CanvasGroup>().alpha = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void StopInteracting()
    {

        Time.timeScale = 1.0f;
        chestInventory.GetComponent<CanvasGroup>().alpha = 0;
        playerInventory.GetComponent<CanvasGroup>().alpha = 0;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
