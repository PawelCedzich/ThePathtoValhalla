using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Slot[] inventorySlots;

    public void Start() 
    {
        inventorySlots = GetComponentsInChildren<Slot>();

    }

    public void AddItem(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].slotItem == null)
            {
                //add Item 
                inventorySlots[i].AddItemToSlot(item);
                break;
            }

            if (i == inventorySlots.Length - 1) {
                Debug.Log("Inventory is full");
            }
        }
    }
}
