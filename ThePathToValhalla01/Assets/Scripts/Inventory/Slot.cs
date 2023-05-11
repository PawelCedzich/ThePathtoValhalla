using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngineInternal;
using static Item;
using Unity.VisualScripting;
using UnityEditor;

public class Slot : MonoBehaviour, IDropHandler, IDataPersistence
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

    public GameObject Instance;
    public GameObject PrefabItem;
    public int slotID = 0;
    public ItemAtlas itemAtlas;
    public GameObject FirstInstance;

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
        Instance = newItem;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (ItemInSlot == null)
        {

            Instance = ItemPrefab.ItemInSlot;
            if (this.slotType == SlotType.BackpackSlot)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.FirstSlot.Instance = null;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;

            }
            else if (this.slotType == SlotType.WeaponSlot && ItemPrefab.DraggedItem.itemType == ItemType.Weapon)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.FirstSlot.Instance = null;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
                ChosenWeapon.CurrentItem(this);
            }
            else if (this.slotType == SlotType.UsableSlot && ItemPrefab.DraggedItem.itemType == ItemType.Food)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.FirstSlot.Instance = null;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
            else if (this.slotType == SlotType.ArmorySlot && ItemPrefab.DraggedItem.itemType == ItemType.Armory)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.FirstSlot.Instance = null;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
        }
    }

    public void LoadData(GameData data)
    {
       
        int value;
        if (data.ItemsInSLots.TryGetValue(slotID, out value))
        {
            Debug.Log(value);
            AddItemToSlot(itemAtlas.GetItemFromList(value));
        }
    }

    public void SaveData(GameData data)
    {
        if (this.Instance == null) {
            data.ItemsInSLots.Remove(slotID);
        }

        if (this.Instance != null) {
            if (data.ItemsInSLots.ContainsKey(slotID))
            {
                data.ItemsInSLots.Remove(slotID);
            }
            data.ItemsInSLots.Add(slotID, this.Instance.GetComponent<ItemPrefab>().item.ID);
        }
    }

}
