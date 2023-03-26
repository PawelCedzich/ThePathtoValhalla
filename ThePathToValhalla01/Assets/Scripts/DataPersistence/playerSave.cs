using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class playerSave : MonoBehaviour, IDataPersistence
{
    public void LoadData(GameData data)
    {
        Debug.Log("loading player position");
        this.transform.position = data.playerPosition;
        Debug.Log("loading player rotation");
        this.transform.rotation = data.playerRotation;
    }

    public void SaveData(GameData data)
    {
        Debug.Log("saving player position");
        data.playerPosition = this.transform.position;
        data.playerRotation = this.transform.rotation;
    }
}
