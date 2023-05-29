using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngineInternal;
using static Item;
using Unity.VisualScripting;
using UnityEditor;
using StarterAssets;

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

    public Item GetCurrentITem() { 
        return this.Instance.GetComponent<ItemPrefab>().item;
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
            else if (this.slotType == SlotType.WeaponSlot && ItemPrefab.DraggedItem.item.itemType == ItemType.Weapon)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.FirstSlot.Instance = null;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
                ChosenWeapon.CurrentItem(this);
            }
            else if (this.slotType == SlotType.UsableSlot && (ItemPrefab.DraggedItem.item.itemType == ItemType.Food || ItemPrefab.DraggedItem.item.itemType == ItemType.HealPotion || ItemPrefab.DraggedItem.item.itemType == ItemType.ConditionPotion || ItemPrefab.DraggedItem.item.itemType == ItemType.DamagePotion || ItemPrefab.DraggedItem.item.itemType == ItemType.SpeedPotion))
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.FirstSlot.Instance = null;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
            else if (this.slotType == SlotType.ArmorySlot && ItemPrefab.DraggedItem.item.itemType == ItemType.Armory)
            {
                ItemPrefab.ItemInSlot.transform.SetParent(this.transform);
                ItemPrefab.IfDropped = true;
                ItemPrefab.FirstSlot.Instance = null;
                ItemPrefab.ItemInSlot.GetComponent<CanvasGroup>().blocksRaycasts = true;
            }
        }
        else if (ItemPrefab.DraggedItem.item == Instance.GetComponent<ItemPrefab>().item) {
            if (Instance.GetComponent<ItemPrefab>().Amount + ItemPrefab.DraggedItem.Amount > 16) {
                return;
            }
            StackItem(ItemPrefab.DraggedItem.Amount);
            ItemPrefab.Destroy(ItemPrefab.ItemInSlot);
            ItemPrefab.IfDropped = true;
        }
    }

    public void StackItem(int itemAmount) {

        string amount = Instance.GetComponent<ItemPrefab>().GetComponentInChildren<Text>().text;
        if (amount == "")
        {
            amount = "1";
        }
        Instance.GetComponent<ItemPrefab>().Amount += itemAmount;
        int temp = int.Parse(amount) + itemAmount;
        Instance.GetComponent<ItemPrefab>().GetComponentInChildren<Text>().text = temp.ToString();
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

    public void UseItem(PlayerStats p, PlayerAttack PlayerAttack, ThirdPersonController thirdPersonController) {
        if (Instance.GetComponent<ItemPrefab>() != null && Instance.GetComponent<ItemPrefab>().item.itemType == ItemType.Food) {
            p.IncreaseHunger(Instance.GetComponent<ItemPrefab>().hungerValue);
        }else if (Instance.GetComponent<ItemPrefab>() != null && Instance.GetComponent<ItemPrefab>().item.itemType == ItemType.HealPotion)
        {
            p.IncreaseHealth(Instance.GetComponent<ItemPrefab>().healValue);
        }
        else if (Instance.GetComponent<ItemPrefab>() != null && Instance.GetComponent<ItemPrefab>().item.itemType == ItemType.ConditionPotion)
        {
            p.IncreaseStamina(Instance.GetComponent<ItemPrefab>().StaminaValue);
        }
        else if (Instance.GetComponent<ItemPrefab>() != null && Instance.GetComponent<ItemPrefab>().item.itemType == ItemType.DamagePotion)
        {
            PlayerAttack.ItemDamage += Instance.GetComponent<ItemPrefab>().DmgAddValue;
        }
        else if (Instance.GetComponent<ItemPrefab>() != null && Instance.GetComponent<ItemPrefab>().item.itemType == ItemType.SpeedPotion)
        {
            thirdPersonController.AddSpeed(Instance.GetComponent<ItemPrefab>().SpeedValue);
        }
    }

}
