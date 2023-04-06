using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item slotItem;
    public Image itemIcon;

    public void AddItemToSlot(Item item)
    {
        slotItem = item;
        itemIcon.sprite = item.icon;
        itemIcon.gameObject.SetActive(true);
    }
}
