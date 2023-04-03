using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSave : MonoBehaviour, IDataPersistence
{
    public PlayerStats playerStats;

    public void LoadData(GameData data)
    {

        Debug.Log("loading player position");
        this.transform.position = data.playerPosition;
        Debug.Log("loading player rotation");
        this.transform.rotation = data.playerRotation;

        Debug.Log("loading player stats");
        this.playerStats.maxHealth = data.maxHealth;
        this.playerStats.currentHealth = data.currentHealth;
        this.playerStats.SetHealthBar();

        this.playerStats.currentLevel = data.currentLevel;
        this.playerStats.currentXP = data.currentXP;
    }

    public void SaveData(GameData data)
    {
        Debug.Log("saving player position");
        data.playerPosition = this.transform.position;
        data.playerRotation = this.transform.rotation;

        data.maxHealth = this.playerStats.maxHealth;
        data.currentHealth = this.playerStats.currentHealth;
        data.currentLevel = this.playerStats.currentLevel;
        data.currentXP = this.playerStats.currentXP;
    }
}
