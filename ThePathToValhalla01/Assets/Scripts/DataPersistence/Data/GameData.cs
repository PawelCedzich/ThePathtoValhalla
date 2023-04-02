using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public Vector3 playerPosition;
    public Quaternion playerRotation;
    public int maxHealth;
    public int currentHealth;
    public HealthBar healthBar;

    public GameData() {
        playerPosition = Vector3.zero;
        playerRotation = Quaternion.identity;
        maxHealth = 50;
        currentHealth = 50;
    }
}
