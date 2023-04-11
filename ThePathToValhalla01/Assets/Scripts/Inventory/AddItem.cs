using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class AddItem : MonoBehaviour
{
    public Item food;
    public Item weapon;
    public Item other;
    public Item armory;
    public InventoryManager inventory;

    public void PickUpItem(Item item) { 
    
        inventory.AddItem(item);
    }

    public void Update()
    {
        if (Input.GetKeyDown("1"))
        { 
            PickUpItem(food);
        }
        if (Input.GetKeyDown("2"))
        {
            PickUpItem(weapon);
        }
        if (Input.GetKeyDown("3"))
        {
            PickUpItem(other);
        }
        if (Input.GetKeyDown("4"))
        {
            PickUpItem(armory);
        }
    }
}
