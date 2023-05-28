using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestRigthManager : MonoBehaviour
{
    public DialogManager dialogManager;

    public Queue<Quest> Quests;
    public Text QuestTittle;
    public Text QuestGoal;

    public Quest curentQuest;
    public void ShowQuest(QuestManager questManager)
    {
        Quests.Clear();

        foreach (Quest quest in questManager.quests)
        {
            if (quest.isCompleted == false) {
                Quests.Enqueue(quest);
            }
        }

        DisplayNextQuest();
    }

    public void DisplayNextQuest()
    {
        if (Quests.Count == 0)
        {
            return;
        }

        Quest quest = new Quest();
        quest = Quests.Dequeue();
        curentQuest = quest;
        QuestTittle.text = quest.Tittle;

        string str= "";
        if (quest.goal.goalType == Goal.GoalType.CollectItem && quest.goal.GoalItem != null)
        {
            str = "Zdobπdü: " + quest.goal.GoalItem.itemName + " x " + quest.goal.GoalAmount;
        }
        else if(quest.goal.goalGameObject != null) {
            str = "Znajdü: " + quest.goal.goalGameObject.name;
        }
        QuestGoal.text = str;


        dialogManager.StartDialog(quest.dialog);

    }


    public void DeleteQuest(QuestManager questManager) {
        curentQuest.IsActive = false;
    }

    void Start()
    {
        Quests = new Queue<Quest>();
    }

    public Quest AddQuest(QuestManager questManager)
    {
        return curentQuest;
    }

    public void ActivateNextQuest(Quest quest)
    {
        Quests.Enqueue(quest);

    }
}
