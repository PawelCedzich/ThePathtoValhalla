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

    public bool isDear01Dead;
    public Vector3 dear01Position;
    public bool isBison01Dead;
    public Vector3 bison01Position;
    public bool isBear01Dead;
    public Vector3 bear01Position;
    public bool isGoblin01Dead;
    public Vector3 goblin01Position;
    public bool isJotun01Dead;
    public Vector3 jotun01Position;
    public bool isNix01Dead;
    public Vector3 nix01Position;




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

        isDear01Dead = false;
        isBison01Dead = false;
        isBear01Dead = false;
        isGoblin01Dead = false;
        isJotun01Dead = false;
        isNix01Dead = false;
    }
}
