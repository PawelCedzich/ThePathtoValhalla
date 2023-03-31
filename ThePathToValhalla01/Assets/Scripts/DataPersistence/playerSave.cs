using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSave : MonoBehaviour, IDataPersistence
{
    private PlayerStats playerStats;
    private void Start()
    {
        playerStats.GetComponent<PlayerStats>();
    }
    public void LoadData(GameData data)
    {
        Debug.Log("loading player position");
        this.transform.position = data.playerPosition;
        Debug.Log("loading player rotation");
        this.transform.rotation = data.playerRotation;
        playerStats.maxHealth = data.maxHealth;
        playerStats.currentHealth = data.currentHealth;
    }

    public void SaveData(GameData data)
    {
        Debug.Log("saving player position");
        data.playerPosition = this.transform.position;
        data.playerRotation = this.transform.rotation;
        data.maxHealth = playerStats.maxHealth;
        data.currentHealth = playerStats.currentHealth;
    }
}
