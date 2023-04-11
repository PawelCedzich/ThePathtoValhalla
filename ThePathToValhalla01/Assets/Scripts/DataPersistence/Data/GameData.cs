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

    public SerializableDictionery<int, int> ItemsInSLots;

    public GameData() {
        playerPosition = Vector3.zero;
        playerRotation = Quaternion.identity;
        maxHealth = 50;
        currentHealth = 50;
        currentLevel = 0;
        currentXP = 0;
        currentHunger = 10;
    }
}
