using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemPrefab : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler
{
    static public GameObject ItemInSlot;
    static public bool IfDropped;
    static public Item DraggedItem;
    static public Slot FirstSlot;


    public Item item;
    Vector2 startPosition;
    Transform startParent;

    public string Description;
    public int Damage = 0;
    public int healValue = 0;
    public int hungerValue = 0;

    public void Start()
    {
        Damage = item.ItemDamage;
        healValue = item.ItemHealthValue;
        hungerValue = item.ItemHungerValue;
    }

    
    public void OnBeginDrag(PointerEventData eventData)
    {
        FirstSlot = gameObject.GetComponentInParent<Slot>();
        ItemInSlot = this.gameObject;
        DraggedItem = this.item;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(transform.parent.parent.parent.parent.parent);
        IfDropped = false;
        
        GetComponent<CanvasGroup>().blocksRaycasts = false; 
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (IfDropped == false) 
        {
            transform.position = startPosition;
            transform.SetParent(startParent, false);

            GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        DraggedItem = null;

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (DraggedItem == null) {

            ItemOnHover._Instance.ShowItemDesc(Description, item.icon, Damage.ToString(), hungerValue.ToString(), healValue.ToString(), item.itemType);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ItemOnHover._Instance.HideItemDesc();
    }
}
