using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public void TimerOut()
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            timerText.text = Mathf.Round(timeStart).ToString();
        }
    }

    public static void AddTenSec()
    {
        timeStart += 10;
    }

    public static float timeStart = 60;
    public Text timerText;
    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    void Update()
    {
        TimerOut();
    }
    
}
