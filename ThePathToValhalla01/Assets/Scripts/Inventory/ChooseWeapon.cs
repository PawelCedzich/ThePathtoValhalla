using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngineInternal;
using static Item;
using UnityEngine.Rendering.UI;
using Unity.VisualScripting;
public class ChooseWeapon : MonoBehaviour
{
    public InventoryManager inventory;
    private Slot currentChosen;

    private void Start()
    {
        currentChosen = inventory.inventorySlots[0];
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("q") && currentChosen == inventory.inventorySlots[0])
        {
            inventory.inventorySlots[1].GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            inventory.inventorySlots[0].GetComponent<Image>().color = new Color32(255, 255, 225, 200);
            currentChosen = inventory.inventorySlots[1];
        }
        else if (Input.GetKeyDown("q") && currentChosen == inventory.inventorySlots[1])
        {
            inventory.inventorySlots[0].GetComponent<Image>().color = new Color32(255, 255, 225, 255);
            inventory.inventorySlots[1].GetComponent<Image>().color = new Color32(255, 255, 225, 200);
            currentChosen = inventory.inventorySlots[0];
        }
    }
}
