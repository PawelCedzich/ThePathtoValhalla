using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anvil : MonoBehaviour, IInteractable
{
    public GameObject player;
    private ItemPrefab item;
    public void Interact()
    {
        if (ChosenWeapon.GetCurrentSlot().Instance != null)
        {
            item = ChosenWeapon.GetCurrentSlot().Instance.GetComponent<ItemPrefab>();
            item.Damage += 5;
            Debug.Log(item.Damage);
        }
    }

    public void StopInteracting()
    {
    }
}
