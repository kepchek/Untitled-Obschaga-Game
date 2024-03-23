using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameSystem : MonoBehaviour
{
    public GameObject MinigameTrigger0;
    public GameObject MinigameTrigger1;
    public GameObject MinigameTrigger2;
    public GameObject MinigameTrigger3;
    public GameObject MinigameTrigger4;

    private void Awake() 
    {
        MinigameTrigger0 = GameObject.Find("MinigameTrigger0");
        MinigameTrigger1 = GameObject.Find("MinigameTrigger1");
        MinigameTrigger2 = GameObject.Find("MinigameTrigger2");
        MinigameTrigger3 = GameObject.Find("MinigameTrigger3");
        MinigameTrigger4 = GameObject.Find("MinigameTrigger4");
    }

 //МЕТОД ДЛЯ ТЕСТА
    private void Update() {
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartMinigame0();
            Debug.Log("Minigame ready!");
        }
    }

    void StartMinigame0()
    {
        MinigameTrigger0.GetComponent<InteractTrigger>().TriggerIsEnabled = true;
    }
    void StartMinigame1()
    {
        MinigameTrigger1.GetComponent<InteractTrigger>().TriggerIsEnabled = true;
    }
    void StartMinigame2()
    {
        MinigameTrigger2.GetComponent<InteractTrigger>().TriggerIsEnabled = true;
    }
    void StartMinigame3()
    {
        MinigameTrigger3.GetComponent<InteractTrigger>().TriggerIsEnabled = true;
    }
    void StartMinigame4()
    {
        MinigameTrigger4.GetComponent<InteractTrigger>().TriggerIsEnabled = true;
    }
    public void ExitMinigame0()
    {
        MinigameTrigger0.GetComponent<InteractTrigger>().TriggerIsEnabled = false;
    }
}
