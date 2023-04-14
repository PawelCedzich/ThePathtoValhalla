using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable {
    public void Interact();
    public void StopInteracting();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractionSource;
    public float InteractionRange = 50;
    public bool isInteracting = false;
    private IInteractable interactObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        int layerMask = 10;
        if (Input.GetKeyDown(KeyCode.F)) {
           
            Ray r = new Ray(InteractionSource.position, InteractionSource.forward);
            Debug.DrawRay(InteractionSource.position, InteractionSource.forward, Color.yellow, layerMask);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractionRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out interactObj))
                {
                    if (isInteracting == false)
                    {

                        Debug.Log("interaction");
                        interactObj.Interact();
                        isInteracting = true;
                    }
                    else
                    {

                        Debug.Log("stopped interaction");
                        interactObj.StopInteracting();
                        isInteracting = false;
                    }
                }
            }
                       
        }
    }
}
