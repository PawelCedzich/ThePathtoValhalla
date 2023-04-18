using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anvil : MonoBehaviour, IInteractable
{
    public GameObject player;
    public void Interact()
    {
        Debug.Log(ChosenWeapon.CurrentItem(ChosenWeapon.GetCurrentSlot()));
    }

    public void StopInteracting()
    {

    }
}
