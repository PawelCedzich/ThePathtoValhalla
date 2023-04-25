using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPointFollow : MonoBehaviour
{
    Transform ParentTransform;
    void Start()
    {
        ParentTransform = transform.parent.transform;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 fixedPos = new Vector3(0f, 0.2f, 0.2f);
        //this.transform.position = ParentTransform.transform.localPosition;
        //this.transform.position += fixedPos;
        //this.transform.rotation = ParentTransform.transform.rotation;
        
    }
}
