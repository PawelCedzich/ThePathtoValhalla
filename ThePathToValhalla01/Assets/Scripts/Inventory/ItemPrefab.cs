using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPrefab : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    static public GameObject ItemInSlot;
    static public bool IfDropped;
    static public Item DraggedItem;

    public Item item;
    Vector2 startPosition;
    Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        ItemInSlot = this.gameObject;
        DraggedItem = this.item;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(transform.parent.parent.parent.parent);
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
}
