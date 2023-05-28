using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

interface IInteractable {
    public void Interact();
    public void StopInteracting();
}

public class Interactor : MonoBehaviour
{
    public Transform InteractionSource;
    public float InteractionRange;
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
        LayerMask layer_mask = (1 << 10);
        if (Input.GetKeyDown(KeyCode.F)) {

            if(isInteracting == false){
                Ray r = new Ray(InteractionSource.position, InteractionSource.forward);
                if (Physics.Raycast(r, out RaycastHit hitInfo, InteractionRange, layer_mask))
                {
                    if (hitInfo.collider.gameObject.TryGetComponent(out interactObj))
                    {
                        Time.timeScale = 0;
                        movCamera.SetActive(false);
                        isInteracting = true;
                        CurentInteracted = interactObj;
                        interactObj.Interact();
                    }
                }
            }else{
                StopInteraction();
            }

        }
    }

    public void StopInteraction() {
        Time.timeScale = 1;
        movCamera.SetActive(true);
        CurentInteracted.StopInteracting();
        isInteracting = false;
    }
}
