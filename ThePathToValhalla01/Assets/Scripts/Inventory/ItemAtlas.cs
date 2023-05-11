using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemAtlas : MonoBehaviour
{
    public Item[] ItemsList;

    public Item GetItemFromList(int ItemID) {

        return ItemsList[ItemID];
            }
}
