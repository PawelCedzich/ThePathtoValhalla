using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Slider slider;
    public TMPro.TMP_Text text;

    private int hunger;
    public void SetHunger(int hunger)
    {
        slider.value = hunger;
        this.hunger = hunger;
    }

    public void SetTXT()
    {
        text.text = hunger + " / 10";
    }
}
