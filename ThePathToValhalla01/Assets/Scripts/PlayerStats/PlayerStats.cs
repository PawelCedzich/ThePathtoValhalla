using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 50;
    public int currentHealth = 50;
    public HealthBar healthBar;

    private int maxLevel = 25;
    public int currentLevel = 0;
    public int currentXP = 0;
    public DisplayLevel displayLevel;


    void Start()
    {
        SetHealthBar();
        SetLevelDisplay();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(5);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            currentXP += 50;
        }
    }

    void FixedUpdate()
    {
        if (currentXP >= 100)
        {
            if (currentLevel < 25)
            {
                currentXP = 0;
                currentLevel++;
                maxHealth += 2;
                SetHealthBar();
                SetLevelDisplay();
            } else
            {
                currentXP = 0;
            }
        }
    }

    public void SetHealthBar()
    {
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
    }

    public void SetLevelDisplay()
    {
        displayLevel.SetDisplay(currentLevel);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {

            currentHealth = 0;
        }

        healthBar.SetHealth(currentHealth);
    }
}
