using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class questtrigger : MonoBehaviour
{
    public QuestManager QuestManager;
    public int iterator;

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
        foreach (Quest quest in QuestManager.quests)
        {
            if (quest.isCompleted == false && quest.IsActive == false)
            {
                quest.IsActive = true;
                FindAnyObjectByType<QuestRigthManager>().ActivateNextQuest(quest);
            }
        }
    }
}
