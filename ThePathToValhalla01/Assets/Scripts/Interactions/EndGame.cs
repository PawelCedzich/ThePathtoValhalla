using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour, IInteractable
{
    public GameObject player;
    public Interactor interactor;
    public void Interact()
    {
        interactor.StopInteraction();
        Cursor.visible = false;
        SceneManager.LoadScene(6);
    }

    public void StopInteracting()
    {

    }

    private void Update()
    {

    }
}
