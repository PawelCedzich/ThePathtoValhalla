using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSave : MonoBehaviour, IDataPersistence
{
    public PlayerStats playerStats;

    public SimpleEnemy dear01;
    public SimpleEnemy bison01;
    public SimpleEnemy bear01;
    public SimpleEnemy goblin01;
    public SimpleEnemy jotun01;

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

        this.playerStats.currentHunger = data.currentHunger;
        this.playerStats.SetHungerBar();

        this.playerStats.currentStamina = data.currentStamina;
        this.playerStats.SetStaminaBar();

        this.playerStats.currentLevel = data.currentLevel;
        this.playerStats.currentXP = data.currentXP;

        this.dear01.isDead = data.isDear01Dead;
        this.dear01.transform.position = data.dear01Position;

        this.bison01.isDead = data.isBison01Dead;
        this.bison01.transform.position = data.bison01Position;

        this.bear01.isDead = data.isBear01Dead;
        this.bear01.transform.position = data.bear01Position;

        this.goblin01.isDead = data.isGoblin01Dead;
        this.goblin01.transform.position = data.goblin01Position;

        this.jotun01.isDead = data.isJotun01Dead;
        this.jotun01.transform.position = data.jotun01Position;
    }

    public void SaveData(GameData data)
    {
        Debug.Log("saving player position");
        data.playerPosition = this.transform.position;
        data.playerRotation = this.transform.rotation;

        data.maxHealth = this.playerStats.maxHealth;
        data.currentHealth = this.playerStats.currentHealth;

        data.currentStamina = this.playerStats.currentStamina;

        data.currentHunger = this.playerStats.currentHunger;

        data.currentLevel = this.playerStats.currentLevel;
        data.currentXP = this.playerStats.currentXP;

        data.isDear01Dead = this.dear01.isDead;
        data.dear01Position = this.dear01.transform.position;

        data.isBison01Dead = this.bison01.isDead;
        data.bison01Position = this.bison01.transform.position;

        data.isBear01Dead = this.bear01.isDead;
        data.bear01Position = this.bear01.transform.position;
        
        data.isGoblin01Dead = this.goblin01.isDead;
        data.goblin01Position = this.goblin01.transform.position;

        data.isJotun01Dead = this.jotun01.isDead;
        data.jotun01Position = this.jotun01.transform.position;
    }

}
