using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChosenWeapon : MonoBehaviour
{
    public InventoryManager inventory;
    private Slot currentChosenSlot;
    public static Item currentItem;
    void Start()
    {
        currentChosenSlot = inventory.inventorySlots[0];
        currentChosenSlot.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }

    void Update()
    {
            if (Input.GetKeyDown("q") && currentChosenSlot == inventory.inventorySlots[0])
            {
                inventory.inventorySlots[1].GetComponent<Image>().color = new Color32(255, 255, 255, 200);
                inventory.inventorySlots[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                currentChosenSlot = inventory.inventorySlots[1];
                if (currentItem != null) {
                    CurrentItem(currentChosenSlot);
                }
                
            }else if (Input.GetKeyDown("q") && currentChosenSlot == inventory.inventorySlots[1]) {
                inventory.inventorySlots[0].GetComponent<Image>().color = new Color32(255, 255, 255, 200);
                inventory.inventorySlots[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                currentChosenSlot = inventory.inventorySlots[0];
                if (currentItem != null)
                {
                    CurrentItem(currentChosenSlot);
                }
        } 
    }

    public static void CurrentItem(Slot slot)
    {
        Debug.Log(slot.Instance.GetComponent<ItemPrefab>().item);
        //currentItem = slot.GetComponent<ItemPrefab>();
        
    }
}
