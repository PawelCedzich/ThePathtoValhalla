using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.SceneView;

public class Chest : MonoBehaviour, IInteractable
{
    public InventoryManager playerInventory;
    public InventoryManager chestInventory;
   


    public void Interact()
    {
        Time.timeScale = 0.0f;
        playerInventory.gameObject.SetActive(true);
        chestInventory.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void StopInteracting()
    {

        Time.timeScale = 1.0f;
        playerInventory.gameObject.SetActive(false);
        chestInventory.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
