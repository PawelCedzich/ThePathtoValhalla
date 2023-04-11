using UnityEngine;
using UnityEngine.UI;

public class ChosenWeapon : MonoBehaviour
{
    public InventoryManager inventory;
    public Slot currentChosen;
    void Start()
    {
        currentChosen = inventory.inventorySlots[0];
        currentChosen.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }

    void Update()
    {
            if (Input.GetKeyDown("q") && currentChosen == inventory.inventorySlots[0])
            {
                inventory.inventorySlots[1].GetComponent<Image>().color = new Color32(255, 255, 255, 200);
                inventory.inventorySlots[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                currentChosen = inventory.inventorySlots[1];
            }else if (Input.GetKeyDown("q") && currentChosen == inventory.inventorySlots[1]) {
                inventory.inventorySlots[0].GetComponent<Image>().color = new Color32(255, 255, 255, 200);
                inventory.inventorySlots[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                currentChosen = inventory.inventorySlots[0];
            } 
    }
}
