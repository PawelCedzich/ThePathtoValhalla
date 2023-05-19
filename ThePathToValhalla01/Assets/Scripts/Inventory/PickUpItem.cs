using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour, IInteractable
{
    public Item item;
    public InventoryManager inventory;

    public void Interact()
    {
        inventory.AddItem(item);
        Destroy(this.gameObject);
    }


    public void StopInteracting()
    {
        
    }
}
