using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    int progress;

    public Slider progressBar;

    void Start()
    {
        progress = 0;    
    }

    void Update()
    {
        progressBar.value = progress;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Click();
        }
    }
    // в кликере не нужны комментарии.
    public void Click()
    {
        progress++;
    }
}
