using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSave : MonoBehaviour, IDataPersistence
{
    public PlayerStats playerStats;
    public SimpleEnemy enemy01;
    public SimpleEnemy enemy02;
    public SimpleEnemy enemy03;
    public SimpleEnemy enemy04;

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

        this.enemy01.isDead = data.isEnemy01Dead;
        this.enemy01.transform.position = data.enemy01Position;
        this.enemy02.isDead = data.isEnemy02Dead;
        this.enemy02.transform.position = data.enemy02Position;
        this.enemy03.isDead = data.isEnemy03Dead;
        this.enemy03.transform.position = data.enemy03Position;
        this.enemy04.isDead = data.isEnemy04Dead;
        this.enemy04.transform.position = data.enemy04Position;
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

        data.isEnemy01Dead = this.enemy01.isDead;
        data.enemy01Position = this.enemy01.transform.position;
        data.isEnemy02Dead = this.enemy02.isDead;
        data.enemy02Position = this.enemy02.transform.position;
        data.isEnemy03Dead = this.enemy03.isDead;
        data.enemy03Position = this.enemy03.transform.position;
        data.isEnemy04Dead = this.enemy04.isDead;
        data.enemy04Position = this.enemy04.transform.position;
    }

}
