using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    public Item item;
    public InventoryManager inventory;

    public void PickUpItem() { 
    
        inventory.AddItem(item);
    }

    public void Update()
    {
        if (Input.GetKeyDown("1"))
        { 
            PickUpItem();
        }
    }
}
