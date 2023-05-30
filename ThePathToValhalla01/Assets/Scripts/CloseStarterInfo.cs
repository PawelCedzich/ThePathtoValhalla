using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseStarterInfo : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            canvas.SetActive(false);
        }
    }
}
