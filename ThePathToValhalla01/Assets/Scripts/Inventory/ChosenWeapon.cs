using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class ChosenWeapon : MonoBehaviour
{
    public InventoryManager inventory;
    public static Slot currentChosenSlot;
    public static Item currentItem;
    public Transform HandPosition;

    public PlayerAttack playerAttack;

    void Start()
    {
        currentChosenSlot = inventory.inventorySlots[0];
        currentChosenSlot.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }

    void Update()
    {
        if (Input.GetKeyDown("q") && currentChosenSlot == inventory.inventorySlots[0])
        {
            inventory.inventorySlots[0].GetComponent<Image>().color = new Color32(255, 255, 255, 200);
            inventory.inventorySlots[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            currentChosenSlot = inventory.inventorySlots[1];

            if (currentChosenSlot.Instance != null) {

                playerAttack.ItemDamage = currentChosenSlot.Instance.GetComponent<ItemPrefab>().Damage;
                //EquipItem();
            }

        }
        else if (Input.GetKeyDown("q") && currentChosenSlot == inventory.inventorySlots[1])
        {
            inventory.inventorySlots[1].GetComponent<Image>().color = new Color32(255, 255, 255, 200);
            inventory.inventorySlots[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            currentChosenSlot = inventory.inventorySlots[0];

            if (currentChosenSlot.Instance != null)
            {
                playerAttack.ItemDamage = currentChosenSlot.Instance.GetComponent<ItemPrefab>().Damage;
                //EquipItem();
            }
        }


    }

    public static Item CurrentItem(Slot slot)
    {

        if (slot.Instance != null)
        {
            return slot.Instance.GetComponent<ItemPrefab>().item;
        }
        return null;

    }
    public static Slot GetCurrentSlot()
    {
        return currentChosenSlot;

    }

    public void EquipItem()
    {
        if (HandPosition.transform.childCount > 0) {
            Destroy(HandPosition.GetChild(0).gameObject);
        }
        GameObject weapon = Instantiate(currentChosenSlot.Instance.GetComponent<ItemPrefab>().item.model);
        weapon.transform.SetParent(HandPosition, true);
        weapon.transform.position = HandPosition.position;
        weapon.transform.rotation = HandPosition.rotation;

    }
}
