using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLevel : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public Image image;

    public void SetDisplay(int currentLvl)
    {
        text.text = currentLvl.ToString();
    }

    public void SetImage(int currentXP)
    {
        image.fillAmount = (float)currentXP / 100.0f;
    }

}
