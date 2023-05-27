using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest 
{
    public bool IsActive;
    public bool isCompleted = false;

    public string Tittle;
    
    public Dialog dialog;

    public Goal goal;


}
