using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngineInternal;
using static UnityEditor.Progress;
using static Item;

public class Slot : MonoBehaviour, IDropHandler
{
    public GameObject ItemInSlot
    {
        get
        {
            if (transform.childCount > 0) {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public GameObject PrefabItem;

    public SlotType slotType = SlotType.BackpackSlot;

    public enum SlotType
    {
        BackpackSlot,
        UsableSlot,
        ArmorySlot,
        WeaponSlot,
    }

    public void AddItemToSlot(Item item)
    {
        GameObject newItem = Instantiate(PrefabItem);
        newItem.transform.SetParent(this.transform);
        newItem.GetComponent<ItemPrefab>().item = item;
        newItem.GetComponent<Image>().sprite = item.icon;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (ItemInSlot == null)
        {

            if (this.slotType == SlotType.BackpackSlot)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;

            }
            else if (this.slotType == SlotType.WeaponSlot && ItemPrefab.DraggedItem.itemType == ItemType.Weapon)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
            else if (this.slotType == SlotType.UsableSlot && ItemPrefab.DraggedItem.itemType == ItemType.Food)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
            else if (this.slotType == SlotType.ArmorySlot && ItemPrefab.DraggedItem.itemType == ItemType.Armory)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
        }
    }
}
