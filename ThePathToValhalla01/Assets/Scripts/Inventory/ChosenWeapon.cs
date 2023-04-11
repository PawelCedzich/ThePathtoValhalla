using UnityEngine;
using UnityEngine.UI;

public class ChosenWeapon : MonoBehaviour
{
    public InventoryManager inventory;
    private Slot currentChosen;
    void Start()
    {
        currentChosen = inventory.inventorySlots[0];
    }

    void Update()
    {
            if (Input.GetKeyDown("q") && currentChosen == inventory.inventorySlots[0])
            {
                inventory.inventorySlots[1].GetComponent<Image>().color = new Color(255, 255, 255, 0);
                inventory.inventorySlots[0].GetComponent<Image>().color = new Color(255, 255, 255, 255);
                currentChosen = inventory.inventorySlots[1];
            }
            if (Input.GetKeyDown("q") && currentChosen == inventory.inventorySlots[1]) {
                Debug.Log("loop 2");
                inventory.inventorySlots[1].GetComponent<Image>().color = new Color(255, 255, 255, 0);
                inventory.inventorySlots[0].GetComponent<Image>().color = new Color(255, 255, 255, 255);
                currentChosen = inventory.inventorySlots[0];
            } 
    }
}
