using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public int QuestID;

    public bool IsActive = false;
    public bool isCompleted = false;
    public bool isColected = false;

    public string Tittle;
    
    public Dialog dialog;

    public Goal goal;

    public int XPAmount;

}
