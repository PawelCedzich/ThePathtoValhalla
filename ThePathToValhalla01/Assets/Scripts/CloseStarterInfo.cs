using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class CloseStarterInfo : MonoBehaviour
{
    public GameObject canvas;
    public bool Paused;

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
            if (Paused == false)
            {
                canvas.SetActive(false);
                Paused = true;
            }
            else
            {
                canvas.SetActive(true);

                Paused = false;
            }
        }
    }
}
