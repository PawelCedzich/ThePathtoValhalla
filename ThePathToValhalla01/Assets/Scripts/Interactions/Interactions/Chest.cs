using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public GameObject playerInventory;
    public InventoryManager chestInventory;
   


    public void Interact()
    {
        Time.timeScale = 0.0f;
        playerInventory.GetComponent<CanvasGroup>().alpha = 1;
        chestInventory.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void StopInteracting()
    {

        Time.timeScale = 1.0f;
        chestInventory.gameObject.SetActive(false);
        playerInventory.GetComponent<CanvasGroup>().alpha = 0;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
