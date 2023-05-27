using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Goal
{
    public Item GoalItem;
    public int GoalAmount;
    public GoalType goalType;
    public questtrigger goalGameObject;

    public enum GoalType
    {
        CollectItem,
        FindPerson,
    }
}
