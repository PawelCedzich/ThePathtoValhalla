using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider slider;
    public TMPro.TMP_Text text;

    private int maxStamina;
    private int stamina;
    public void SetMaxStamina(int stamina)
    {
        slider.maxValue = stamina;
        slider.value = stamina;
        this.maxStamina = stamina;
    }


    public void SetStamina(int stamina)
    {
        slider.value = stamina;
        this.stamina = stamina;
    }

    public void SetTXT()
    {
        text.text = stamina + " / " + maxStamina;
    }
}
