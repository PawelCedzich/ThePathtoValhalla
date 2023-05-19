using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public Slot[] inventorySlots;
    public  bool ActiveStart;

    public void Start() 
    {
        inventorySlots = GetComponentsInChildren<Slot>();

    }

    public void AddItem(Item item)
    {
        if (item.IsStackable == true)
        {
            for (int i = 0; i < inventorySlots.Length; i++)
            {
                if (inventorySlots[i].Instance != null && item == inventorySlots[i].GetCurrentITem())
                {
                    inventorySlots[i].StackItem();
                    return;
                }
            }
        }
        for (int i = 0; i < inventorySlots.Length; i++)
        {

            if (inventorySlots[i].ItemInSlot == null)
            {
                inventorySlots[i].AddItemToSlot(item);
                break;
            }

            if (i == inventorySlots.Length - 1)
            {
                Debug.Log("Inventory is full");
            }
       
        }
        
    }

}
