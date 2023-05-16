using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anvil : MonoBehaviour, IInteractable
{
    public GameObject player;
    private ItemPrefab item;
    public GameObject canvas;
    private int timer;
    public void Interact()
    {
            canvas.SetActive(true);
            timer = 360;
        
    }

    public void StopInteracting()
    {
        canvas.SetActive(false);
        if (ChosenWeapon.GetCurrentSlot().Instance != null)
        {
            item = ChosenWeapon.GetCurrentSlot().Instance.GetComponent<ItemPrefab>();
            item.Damage += 5;
            Debug.Log(item.Damage);
        }
    }

    private void Update()
    {
        timer -= 1;
    }
}
