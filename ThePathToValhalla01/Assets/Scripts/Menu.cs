using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadSceneAsync(5).completed += OnSceneLoaded;
        DataPersistenceManager.instance.NewGame();
    }

    private void OnSceneLoaded(AsyncOperation asyncOp)
    {
        if (asyncOp.isDone)
        {
            DataPersistenceManager.instance.NewGame();
        }
    }

    public void ContinueGame()
    {
        Debug.Log("load");
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadSceneAsync(1).completed += OnSaveLoaded;
        DataPersistenceManager.instance.LoadGame();
    }
    private void OnSaveLoaded(AsyncOperation asyncOp)
    {
        if (asyncOp.isDone)
        {
            DataPersistenceManager.instance.LoadGame();
        }
    }

    public void QuitToMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void SaveGame()
    {
        DataPersistenceManager.instance.SaveGame();
        Debug.Log("Game Saved Manually.");
    }

}
