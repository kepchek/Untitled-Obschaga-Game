using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    int progress;

    public GameObject Minigame3GameArea;
    public GameObject MinigameTrigger3;

    public Slider progressBar;

    void OnEnable()
    {
        progress = 0;    
    }

    void Update()
    {
        progressBar.value = progress;
        if (progress >= 10)
        {
            ExitMinigame3();
        }
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

    public void ExitMinigame3()
    {
        Minigame3GameArea.SetActive(false);
        MinigameTrigger3.GetComponent<InteractTrigger>().TriggerIsEnabled = false;
    }
}
