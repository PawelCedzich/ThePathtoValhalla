using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NpcQuest : MonoBehaviour, IInteractable
{
    public Quest quest; 
    public PlayerStats playerStats;

    public GameObject QuestWindow;

    public Text QuestText;
    public Text QuestTitle;
    public void Interact()
    {

        QuestWindow.SetActive(true);
        QuestTitle.text = quest.Tittle;
        QuestText.text = quest.Description;
        Cursor.lockState = CursorLockMode.None;
    }

    public void StopInteracting()
    {
        QuestWindow.SetActive(false); 
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void AcceptQuest()
    {
        playerStats.Quests.Add(quest);
    }
}

