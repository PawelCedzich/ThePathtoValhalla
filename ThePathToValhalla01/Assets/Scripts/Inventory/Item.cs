using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/NewItem")]
public class Item : ScriptableObject
{
    public int ID;
    public string itemName = "NewItem";
    public Sprite icon = null;
    public ItemType itemType = ItemType.Other;
    public GameObject model;
    public int ItemDamage;


    public enum ItemType
    {
        Food,
        Weapon,
        Other,
        Armory,
    }

}
