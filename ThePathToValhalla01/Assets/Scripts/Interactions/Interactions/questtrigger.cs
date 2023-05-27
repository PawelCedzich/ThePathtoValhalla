using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class questtrigger : MonoBehaviour
{
    public QuestManager QuestManager;
    private int iterator;

    public void TriggerQuest()
    {

        FindAnyObjectByType<QuestRigthManager>().ShowQuest(QuestManager);
    }

    public bool CheckQuests()
    {
        if (QuestManager.quests.Count() == iterator)
        {
            return true;
        }
        else {
            return false;
        }
    }

    public void DeleteQuest() {
        FindAnyObjectByType<QuestRigthManager>().DeleteQuest(QuestManager);
    }
    public Quest AddQuest()
    {

        return FindAnyObjectByType<QuestRigthManager>().AddQuest(QuestManager);
    }

    public void ActivateNextQuest()
    {
        iterator++;
        if(iterator < QuestManager.quests.Count())
        {
            QuestManager.quests[iterator].IsActive = true;
            FindAnyObjectByType<QuestRigthManager>().ActivateNextQuest(QuestManager.quests[iterator]);
        }

    }
}
