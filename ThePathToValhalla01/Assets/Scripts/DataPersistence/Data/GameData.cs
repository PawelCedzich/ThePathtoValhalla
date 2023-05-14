using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

[System.Serializable]

public class GameData
{
    public Vector3 playerPosition;
    public Quaternion playerRotation;
    public int maxHealth;
    public int currentHealth;
    public HealthBar healthBar;
    public int currentLevel;
    public int currentXP;
    public int currentHunger;
    public int currentStamina;

    public bool isEnemy01Dead;
    public Vector3 enemy01Position;
    public bool isEnemy02Dead;
    public Vector3 enemy02Position;
    public bool isEnemy03Dead;
    public Vector3 enemy03Position;
    public bool isEnemy04Dead;
    public Vector3 enemy04Position;


    public SerializableDictionery<int, int> ItemsInSLots;

    public GameData() {
        playerPosition = Vector3.zero;
        playerRotation = Quaternion.identity;
        maxHealth = 50;
        currentHealth = 50;
        currentLevel = 0;
        currentXP = 0;
        currentHunger = 10;
        currentStamina = 100;

        isEnemy01Dead = false;
        isEnemy02Dead = false;
        isEnemy03Dead = false;
        isEnemy04Dead = false;
    }
}
