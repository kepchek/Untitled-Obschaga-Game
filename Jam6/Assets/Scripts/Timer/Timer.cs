using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;

public class Timer : MonoBehaviour
{

    [SerializeField] GameObject LoseMenu;
    [SerializeField] GameObject WinMenu;
    public void TimerOut()
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            timerText.text = Mathf.Round(timeStart).ToString();
        }
        else
        {
            if(Scores.GetScore() > 0)
            {
                Time.timeScale = 0f;
                WinMenu.SetActive(true);
            }
            else 
            {
                LoseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public static void AddTenSec()
    {
        timeStart += 10;
    }

    public static float timeStart = 300;
    public TMP_Text timerText;
    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    void FixedUpdate()
    {
        TimerOut();
    }
    
}
