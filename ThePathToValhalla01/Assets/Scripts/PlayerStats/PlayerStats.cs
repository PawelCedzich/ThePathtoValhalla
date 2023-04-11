using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 50;
    public int currentHealth = 50;
    public HealthBar healthBar;
    public Image getDamageEffect;
    private float fadeSpeed = 1f;

    private int maxHunger = 10;
    public int currentHunger = 0;
    public HungerBar hungerBar;


    private int maxLevel = 25;
    public int currentLevel = 0;
    public int currentXP = 0;
    public DisplayLevel displayLevel;



    void Start()
    {
        SetHealthBar();
        SetLevelDisplay();
        SetHungerBar();
        InvokeRepeating("DecreaseHunger", 10.0f, 10.0f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(5);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            currentXP += 30;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            IncreaseHunger(1);
        }
    }

    void FixedUpdate()
    {
        SetLevelDisplay();

        if (currentXP >= 100)
        {
            if (currentLevel < maxLevel)
            {
                currentXP -= 100;
                currentLevel++;
                maxHealth += 2;
                SetHealthBar();
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
        healthBar.SetTXT();
    }

    public void SetHungerBar()
    {
        hungerBar.SetHunger(currentHunger);
        hungerBar.SetTXT();
    }

    public void IncreaseHunger(int eatPoints)
    {
        currentHunger += eatPoints;
        if (currentHunger > maxHunger)
        {
            currentHunger = maxHunger;
        }
        SetHungerBar();
    }

    public void DecreaseHunger()
    {
        if (currentHunger > 0)
        {
            currentHunger -= 1;
        }
        else
        {
            TakeDamage(3);
        }
        SetHungerBar();
    }

    public void SetLevelDisplay()
    {
        displayLevel.SetDisplay(currentLevel);
        if (currentLevel == 25)
        {
            displayLevel.SetImage(100);
            displayLevel.GigaChad();
        }
        else
        {

            displayLevel.SetImage(currentXP);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {

            currentHealth = 0;
        }

        if (currentHealth > 0) {
            var tempColor = getDamageEffect.color;
            tempColor.a = 0.5f;
            getDamageEffect.color = tempColor;
            StartCoroutine(FadeScreenEffect());
        }
        SetHealthBar();
    }

    IEnumerator FadeScreenEffect()
    {
        var tempColor = getDamageEffect.color;
        yield return null;
        while (tempColor.a > 0)
        {
            tempColor.a -= fadeSpeed * Time.deltaTime;
            getDamageEffect.color = tempColor;
            yield return null;
        }

        // Ensure the canvas is fully faded out
        tempColor.a = 0f;
        getDamageEffect.color = tempColor;
    }
}
