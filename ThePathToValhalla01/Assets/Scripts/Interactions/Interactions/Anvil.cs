using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anvil : MonoBehaviour, IInteractable
{
    public GameObject player;
    private ItemPrefab item;
    public GameObject canvas;
    public Interactor interactor;
    public bool upgradedWeapon = false;
    private int timer;
    public void Interact()
    {
        if (timer < 0)
        {
            upgradedWeapon = false;
            canvas.SetActive(true);
        }
        else {
            interactor.StopInteraction();
        }
        
    }

    public void StopInteracting()
    {
        canvas.SetActive(false);
        if (ChosenWeapon.GetCurrentSlot().Instance != null && upgradedWeapon == false)
        {
            item = ChosenWeapon.GetCurrentSlot().Instance.GetComponent<ItemPrefab>();
            item.Damage += 5;
            timer = 3600;
            upgradedWeapon = true;
        }
    }

    private void Update()
    {
        timer -= 1;
    }
}
