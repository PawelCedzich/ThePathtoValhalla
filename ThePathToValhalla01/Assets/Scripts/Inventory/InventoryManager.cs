using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
                if (inventorySlots[i].Instance != null && item == inventorySlots[i].GetCurrentITem() && inventorySlots[i].Instance.GetComponent<ItemPrefab>().Amount <= 16)
                {
                    inventorySlots[i].StackItem(1);
                    return;
                }
            }
        }
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (i == inventorySlots.Length - 1)
            {
                Debug.Log("Inventory is full");
            }

            if (inventorySlots[i].ItemInSlot == null)
            {
                inventorySlots[i].AddItemToSlot(item);
                inventorySlots[i].Instance.GetComponent<ItemPrefab>().Amount = 1;
                break;
            }
        }
    }

    public ItemPrefab searchForItem(Item item)
    {
        foreach (Slot slot in inventorySlots)
        {
            if (slot.Instance != null)
            {
                if (slot.GetCurrentITem() == item)
                {
                    return slot.Instance.GetComponent<ItemPrefab>(); ;
                }
            }
        }
        return null;

    }
}
