using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

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
        questtrigger.DeleteQuest();

        if (questtrigger.AddQuest().goal.goalType == Goal.GoalType.FindPerson) {
            questtrigger.ActivateNextQuest();
            questtrigger.QuestManager.quests[questtrigger.iterator-1].goal.goalGameObject.ActivateNextQuest();
        }
        foreach (Quest quest in playerStats.Quests)
        {
            if (quest == questtrigger.AddQuest()) {
                return;
            }
        }

        playerStats.Quests.Add(questtrigger.AddQuest());
        CloseInteraction(); 
    }

    public void CompleteQuest() {
        foreach (Quest quest in playerStats.Quests)
        {

            if (inventoryManager.searchForItem(quest.goal.GoalItem) != null)
            {
                ItemPrefab item = inventoryManager.searchForItem(quest.goal.GoalItem);
                if (item.Amount >= quest.goal.GoalAmount)
                {
                    item.SubtractItemAmount(quest.goal.GoalAmount);
                    questtrigger.ActivateNextQuest();
                    CloseInteraction();
                }
            }
        }


    }


}

