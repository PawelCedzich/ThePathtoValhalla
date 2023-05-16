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

        
        playerStats.Quests.Add(questtrigger.AddQuest());
        CloseInteraction(); 
    }

}

