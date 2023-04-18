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
    static private IInteractable CurentInteracted;
    public GameObject movCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        int layerMask = 10;
        if (Input.GetKeyDown(KeyCode.F)) {

            if(isInteracting == false){
                Ray r = new Ray(InteractionSource.position, InteractionSource.forward);
                Debug.DrawRay(InteractionSource.position, InteractionSource.forward, Color.yellow, layerMask);
                if (Physics.Raycast(r, out RaycastHit hitInfo, InteractionRange))
                {
                    if (hitInfo.collider.gameObject.TryGetComponent(out interactObj))
                    {
                        movCamera.SetActive(false);
                        Debug.Log("interaction");
                        interactObj.Interact();
                        isInteracting = true;
                        CurentInteracted = interactObj;
                    }
                }
            }else{

                movCamera.SetActive(true);
                Debug.Log("stopped interaction");
                CurentInteracted.StopInteracting();
                isInteracting = false;
            }

        }
    }
}
