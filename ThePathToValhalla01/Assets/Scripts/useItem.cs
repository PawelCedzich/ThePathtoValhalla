using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class useItem : MonoBehaviour
{
    public PlayerStats playerStats;
    public InventoryManager inventoryManager;
    public PlayerAttack playerAttack;
    public ThirdPersonController thirdPersonController;
    public SoundPlayer soundPlayer;
    void Update()
    {
        if (Input.GetKeyDown("1") && inventoryManager.inventorySlots[2].Instance != null) {
            inventoryManager.inventorySlots[2].UseItem(playerStats, playerAttack, thirdPersonController);
            inventoryManager.inventorySlots[2].Instance.GetComponent<ItemPrefab>().SubtractItemAmount(1);
            soundPlayer.PlaySound("eating", 1.0f, 0.3f);
        }
        if (Input.GetKeyDown("2") && inventoryManager.inventorySlots[3].Instance != null)
        {
            inventoryManager.inventorySlots[3].UseItem(playerStats, playerAttack, thirdPersonController);
            inventoryManager.inventorySlots[3].Instance.GetComponent<ItemPrefab>().SubtractItemAmount(1);
            soundPlayer.PlaySound("eating", 1.0f, 0.3f);
        }
        if (Input.GetKeyDown("3") && inventoryManager.inventorySlots[4].Instance != null)
        {
            inventoryManager.inventorySlots[4].UseItem(playerStats, playerAttack, thirdPersonController);
            inventoryManager.inventorySlots[4].Instance.GetComponent<ItemPrefab>().SubtractItemAmount(1);
            soundPlayer.PlaySound("eating", 1.0f, 0.3f);
        }
    }
}
