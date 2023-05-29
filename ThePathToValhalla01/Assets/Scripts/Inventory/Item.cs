using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

[CreateAssetMenu(fileName = "NewItem", menuName = "Inventory/NewItem")]
public class Item : ScriptableObject
{
    public int ID;
    public string itemName = "NewItem";
    public Sprite icon = null;
    public ItemType itemType = ItemType.Other;
    public GameObject model;

    public bool IsStackable = false;
    public int Amount = 1;

    public int ItemDamage;
    public int ItemHungerValue;
    public int ItemHealthValue;
    public int StaminaValue;
    public int SpeedValue;
    public int DmgAddValue;


    public enum ItemType
    {
        Food,
        HealPotion,
        ConditionPotion,
        DamagePotion,
        SpeedPotion,
        Weapon,
        Other,
        Armory,
    }

}
