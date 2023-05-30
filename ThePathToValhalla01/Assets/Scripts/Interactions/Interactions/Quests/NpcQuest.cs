using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NpcQuest : MonoBehaviour, IInteractable, IDataPersistence
{

    public PlayerStats playerStats;
    public InventoryManager inventoryManager;

    public questtrigger questtrigger;

    public AddQuestToStackPanel addQuestToStackPanel;

    public GameObject QuestWindow;
    public Text QuestText;
    public Text QuestTitle;
    public Interactor interactor;
    public void Interact()
    {
        if (!questtrigger.CheckQuests())
        {
            Cursor.lockState = CursorLockMode.None;
            QuestWindow.SetActive(true);

            questtrigger.TriggerQuest();
        }
        else {
            CloseInteraction();
        }
    }

    private void CloseInteraction()
    {
        StopInteracting();
        interactor.StopInteraction();
    }

    public void StopInteracting()
    {
        QuestWindow.SetActive(false); 
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void AcceptQuest()
    {

        if (questtrigger.AddQuest().goal.goalType == Goal.GoalType.FindPerson)
        {
            questtrigger.ActivateNextQuest(); 
            questtrigger.QuestManager.quests[questtrigger.AddQuest().goal.goalGameObject.iterator].isCompleted = true;
            if (questtrigger.AddQuest().QuestRewardIem != null)
            {
                inventoryManager.AddItem(questtrigger.AddQuest().QuestRewardIem);

            }
            questtrigger.QuestManager.quests[questtrigger.AddQuest().goal.goalGameObject.iterator].goal.goalGameObject.ActivateNextQuest();
            questtrigger.QuestManager.quests[questtrigger.AddQuest().goal.goalGameObject.iterator].goal.goalGameObject.iterator++;
            questtrigger.iterator++;
        }
        foreach (Quest quest in playerStats.Quests)
        {
            if (quest == questtrigger.AddQuest())
            {
                return;
            }
        }
        questtrigger.AddQuest().isColected = true;
        addQuestToStackPanel.AddItem(questtrigger.AddQuest());
        playerStats.Quests.Add(questtrigger.AddQuest());
        CloseInteraction(); 
    }

    public void CompleteQuest()
    {
        foreach (Quest quest in playerStats.Quests)
        {

            if (inventoryManager.searchForItem(quest.goal.GoalItem) != null)
            {
                ItemPrefab item = inventoryManager.searchForItem(quest.goal.GoalItem);
                if (item.Amount >= quest.goal.GoalAmount)
                {
                    questtrigger.iterator++;
                    item.SubtractItemAmount(quest.goal.GoalAmount);
                    playerStats.IncreaseXP(quest.XPAmount);
                    questtrigger.FindAnyObjectByType<QuestRigthManager>().AddQuest(questtrigger.QuestManager).isCompleted = true;
                    if (questtrigger.AddQuest().QuestRewardIem != null)
                    {
                        inventoryManager.AddItem(questtrigger.AddQuest().QuestRewardIem);

                    }
                    questtrigger.ActivateNextQuest();
                    CloseInteraction();
                }
            }
        }


    }

    public void LoadData(GameData data)
    {
        bool value;
        int valueID;

        if (data.NpcQuestTriggerID.TryGetValue(questtrigger.QuestTriggerId, out valueID))
        {
            questtrigger.QuestTriggerId = valueID;
        }

        foreach (Quest quest in questtrigger.QuestManager.quests)
        {
            if (data.NpcQuestActive.TryGetValue(quest.QuestID, out value))
            {
                quest.IsActive = value;
            }

            if (data.NpcQuestCompleted.TryGetValue(quest.QuestID, out value))
            {
                quest.isCompleted = value;

            }

            if (data.NpcQuestPlayerCollected.TryGetValue(quest.QuestID, out value))
            {
                quest.isColected = value;
                if (quest.isColected == true) {
                    playerStats.Quests.Add(quest);
                }
            }
        }
    }

    public void SaveData(GameData data)
    {
        if (data.NpcQuestTriggerID.ContainsKey(questtrigger.QuestTriggerId))
        {
            data.NpcQuestTriggerID.Remove(questtrigger.QuestTriggerId);
        }
        data.NpcQuestTriggerID.Add(questtrigger.QuestTriggerId, questtrigger.iterator);

        foreach (Quest quest in questtrigger.QuestManager.quests)
        {
            if (data.NpcQuestActive.ContainsKey(quest.QuestID))
            {
                data.NpcQuestActive.Remove(quest.QuestID);
            }
            data.NpcQuestActive.Add(quest.QuestID, quest.IsActive);


            if (data.NpcQuestCompleted.ContainsKey(quest.QuestID))
            {
                data.NpcQuestCompleted.Remove(quest.QuestID);
            }
            data.NpcQuestCompleted.Add(quest.QuestID, quest.isCompleted);


            if (data.NpcQuestPlayerCollected.ContainsKey(quest.QuestID))
            {
                data.NpcQuestPlayerCollected.Remove(quest.QuestID);
            }
            data.NpcQuestPlayerCollected.Add(quest.QuestID, quest.isColected);
        }
    }

}

