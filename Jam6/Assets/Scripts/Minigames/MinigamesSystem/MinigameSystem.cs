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
    private void Awake() {
        MinigameTrigger0 = GameObject.Find("MiniGameTrigger0");
    }

    void StartMinigame0()
    {
        
    }
}
