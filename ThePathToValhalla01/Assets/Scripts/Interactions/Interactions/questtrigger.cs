using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questtrigger : MonoBehaviour
{
    public QuestManager QuestManager;

    public void TriggerQuest()
    {

        FindAnyObjectByType<QuestRigthManager>().ShowQuest(QuestManager);
    }

    public bool CheckQuests()
    {
        return FindAnyObjectByType<QuestRigthManager>().CheckAvailibleQuests(QuestManager);
    }

    public void DeleteQuest() {
        FindAnyObjectByType<QuestRigthManager>().DeleteQuest(QuestManager);
    }
}
