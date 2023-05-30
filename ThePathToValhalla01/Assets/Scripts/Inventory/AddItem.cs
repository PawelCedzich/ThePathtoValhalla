using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    public InventoryManager inventory;

    public void PickUpItem(Item item) { 
    
        inventory.AddItem(item);
    }

    public void Update()
    {
        
    }
}
