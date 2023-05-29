using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class AddQuestToStackPanel : MonoBehaviour
{
    public GameObject ButtonPrefab;
    public void AddItem(Quest quest)
    {
        GameObject newItem = Instantiate(ButtonPrefab);
        newItem.transform.SetParent(this.transform);

        newItem.transform.GetChild(0).GetComponent<Text>().text = quest.Tittle;

        string str = "";
        if (quest.goal.goalType == Goal.GoalType.CollectItem && quest.goal.GoalItem != null)
        {
            str = "Zdob¹dŸ: " + quest.goal.GoalItem.itemName + " x " + quest.goal.GoalAmount;
        }
        else if (quest.goal.goalGameObject != null)
        {
            str = "ZnajdŸ: " + quest.goal.goalGameObject.name;
        }
        newItem.transform.GetChild(1).GetComponent<Text>().text = str;

        if (quest.goal.goalType == Goal.GoalType.CollectItem) {
            if (quest.isCompleted == true)
            {
                newItem.transform.GetChild(2).GetComponent<Text>().text = "Ukoñczono";
            }
            else
            {
                newItem.transform.GetChild(2).GetComponent<Text>().text = "Nie ukoñczono";
            }
        }
    }
}
