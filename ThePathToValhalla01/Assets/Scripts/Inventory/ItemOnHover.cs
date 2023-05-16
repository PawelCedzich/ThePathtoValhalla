using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;
using static Item;

public class ItemOnHover : MonoBehaviour
{
    public static ItemOnHover _Instance;

    public TextMeshProUGUI ItemDesc;
    public TextMeshProUGUI ItemValue;
    public Image ItemImage;

    private void Awake()
    {
        if (_Instance != null && _Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _Instance = this;
        }
    }
    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        this.transform.position = Input.mousePosition;
    }

    public void ShowItemDesc(string Description, Sprite sprite, string itemValue, string hungerValue, string healthValue, ItemType itemType) 
    {
        gameObject.SetActive(true);
        ItemDesc.text = Description;
        this.transform.position = Input.mousePosition;
        ItemImage.sprite = sprite;
        if (itemType == ItemType.Weapon) {
            ItemValue.text = "dmg : " + itemValue;
        }
    else if (itemType == ItemType.Food)
        {
            ItemValue.text = "Hunger : " + hungerValue;
        }
        if (itemType == ItemType.Other)
        {
            ItemValue.text = "health : " + healthValue;
        }

    }

    public void HideItemDesc()
    {
        gameObject.SetActive(false);
    }


}
