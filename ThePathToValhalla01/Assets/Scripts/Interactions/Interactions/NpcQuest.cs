using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NpcQuest : MonoBehaviour, IInteractable
{

    public PlayerStats playerStats;
    public InventoryManager inventoryManager;

    public questtrigger questtrigger;

    public GameObject QuestWindow;
    public Text QuestText;
    public Text QuestTitle;
    public Interactor interactor;
    public void Interact()
    {
        if (!questtrigger.CheckQuests())
        {
            QuestWindow.SetActive(true);
            Cursor.lockState = CursorLockMode.None;


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
            questtrigger.QuestManager.quests[questtrigger.iterator].isCompleted = true;
            questtrigger.QuestManager.quests[questtrigger.iterator].goal.goalGameObject.ActivateNextQuest();
            questtrigger.QuestManager.quests[questtrigger.iterator].goal.goalGameObject.iterator++;
            questtrigger.iterator++;
        }
        foreach (Quest quest in playerStats.Quests)
        {
            if (quest == questtrigger.AddQuest())
            {
                return;
            }
        }
        
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
                    questtrigger.ActivateNextQuest();
                    CloseInteraction();
                }
            }
        }


    }


}

