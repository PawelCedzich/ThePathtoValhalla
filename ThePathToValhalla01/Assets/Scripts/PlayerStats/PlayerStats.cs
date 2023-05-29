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

    public int maxStamina = 100;
    public int currentStamina = 50;
    public StaminaBar staminaBar;

    private int maxHunger = 10;
    public int currentHunger = 10;
    public HungerBar hungerBar;

    private int maxLevel = 25;
    public int currentLevel = 0;
    public int currentXP = 0;
    public DisplayLevel displayLevel;

    public List<Quest> Quests = new List<Quest>();


    public SoundPlayer soundPlayer;
    void Start()
    {
        SetHealthBar();
        SetLevelDisplay();
        SetHungerBar();
        SetStaminaBar();
        InvokeRepeating("DecreaseHunger", 15.0f, 15.0f);
        InvokeRepeating("HealthRegen", 1.0f, 1.0f);
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
                soundPlayer.PlaySound("lvl_up", 0.1f, 0.0f);
                currentXP -= 100;
                currentLevel++;
                maxHealth += 2;
                SetHealthBar();
            } else
            {
                currentXP = 0;
            }
        }

        SetStaminaBar();
    }

    public void HealthRegen()
    {
        if (currentStamina >= 90 && currentHealth < maxHealth && currentHunger > 0)
        {
            currentHealth += 1;
        }
        SetHealthBar();
    }

    public void SetHealthBar()
    {
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(currentHealth);
        healthBar.SetTXT();
    }

    public void SetStaminaBar()
    {
        staminaBar.SetMaxStamina(maxStamina);
        staminaBar.SetStamina(currentStamina);
        staminaBar.SetTXT();
    }

    public void SetHungerBar()
    {
        hungerBar.SetHunger(currentHunger);
        hungerBar.SetTXT();
    }
    public void IncreaseStamina(int StaminaPoints)
    {
        currentStamina += StaminaPoints;
        if (currentStamina > maxStamina)
        {
            currentStamina = maxStamina;
        }
        SetHungerBar();
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

    public void IncreaseHealth(int healPoints)
    {
        currentHealth += healPoints;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        SetHealthBar();
    }

    public void DecreaseHunger()
    {
        if (currentHunger > 0)
        {
            currentHunger -= 1;
            if (currentHunger < 3) {
                soundPlayer.PlaySound("hunger", 0.4f, 0.0f);
            }
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

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {

            currentHealth = 0;
        }

        if (currentHealth > 0) {
            soundPlayer.PlaySound("hp_hurt", 0.6f, 0.0f);
            var tempColor = getDamageEffect.color;
            tempColor.a = 0.5f;
            getDamageEffect.color = tempColor;
            StartCoroutine(FadeScreenEffect());
        }
        SetHealthBar();
    }

    public void IncreaseXP(int XP)
    {
        currentXP += XP;
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
