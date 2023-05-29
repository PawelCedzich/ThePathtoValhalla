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
    public SoundPlayer soundPlayer;
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
            soundPlayer.PlaySound("anvil", 1.0f, 0.0f);
            item = ChosenWeapon.GetCurrentSlot().Instance.GetComponent<ItemPrefab>();
            item.Damage += 5;
            item.WasUpgraded = true;
            timer = 3600;
            upgradedWeapon = true;
        }
    }

    private void Update()
    {
        timer -= 1;
    }
}
