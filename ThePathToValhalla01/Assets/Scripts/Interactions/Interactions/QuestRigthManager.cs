using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestRigthManager : MonoBehaviour
{
    private bool NoMoreQuests = false;
    public DialogManager dialogManager;

    private Queue<Quest> Quests;
    public Text QuestTittle;
    public Quest curentQuest;
    public void ShowQuest(QuestManager questManager)
    {
        Quests.Clear();

        foreach (Quest quest in questManager.quests)
        {
            if (quest.IsActive == true) {
                Quests.Enqueue(quest);
            }
        }

        DisplayNextQuest();
    }

    public void DisplayNextQuest()
    {
        if (Quests.Count == 0)
        {
            EndQuests();
            return;
        }

        Quest quest = new Quest();
        quest = Quests.Dequeue();
        curentQuest = quest;
        QuestTittle.text = quest.Tittle;


        dialogManager.StartDialog(quest.dialog);

    }
    private void EndQuests()
    {
        NoMoreQuests = true;
    }

    public bool CheckAvailibleQuests(QuestManager questManager)
    {
        if (NoMoreQuests == true) {
            return true;
        }
        else { 
            return false; 
        }
    }

    public void DeleteQuest(QuestManager questManager) {
        curentQuest.IsActive = false;
    }

    void Start()
    {
        Quests = new Queue<Quest>();
    }
}
