using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCredits : MonoBehaviour
{
    [SerializeField]
    private int counter;

    private int time = 25;
    IEnumerator credits()
    {
        StartCoroutine(countTime());
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(0);
    }

    IEnumerator countTime()
    {
        while (counter >= 0)
        {
            yield return new WaitForSeconds(1);
            counter -= 1;
        }
    }

    void Start()
    {
        counter = time;
        StartCoroutine(credits());
    }

    void Update()
    {
        
    }
}
