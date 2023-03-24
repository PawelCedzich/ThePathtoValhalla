using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        DataPersistenceManager.instance.NewGame();
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        DataPersistenceManager.instance.SaveGame();
    }

    public void ContinueGame()
    {
        Debug.Log("load");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        DataPersistenceManager.instance.LoadGame();
    }
}
