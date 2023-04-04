using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public TMPro.TMP_Text text;

    private int maxHealth;
    private int health;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        this.maxHealth = health;
    }


    public void SetHealth(int health)
    {
        slider.value = health;
        this.health = health;
    } 

    public void SetTXT()
    {
        text.text = health + " / " + maxHealth;
    }
}
