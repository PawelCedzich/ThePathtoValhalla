using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class useItem : MonoBehaviour
{
    public PlayerStats playerStats;
    public InventoryManager inventoryManager;
    void Update()
    {
        if (Input.GetKeyDown("3") && inventoryManager.inventorySlots[2].Instance != null) {
            inventoryManager.inventorySlots[2].UseItem(playerStats);
            inventoryManager.inventorySlots[2].Instance.GetComponent<ItemPrefab>().SubtractItemAmount(1);

        }
    }
}
