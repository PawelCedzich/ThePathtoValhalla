using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorQuest : MonoBehaviour
{
    public GameObject questWindow;

    void Update()
    {
        if (questWindow != null)
        {
            if (questWindow.activeSelf)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
