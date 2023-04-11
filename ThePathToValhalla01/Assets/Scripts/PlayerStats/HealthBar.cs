using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        if (this.health <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            StartCoroutine(LoadLevelAsync());
        }
    } 

    public void SetTXT()
    {
        text.text = health + " / " + maxHealth;
    }

    IEnumerator LoadLevelAsync()
    {
        yield return null;

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(3);
        asyncOperation.allowSceneActivation = false;
        while (asyncOperation.isDone != true)
        {
            Debug.Log("Loading progress: " + (asyncOperation.progress * 100) + "%");
            if (asyncOperation.progress >= 0.9f)
            {
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
