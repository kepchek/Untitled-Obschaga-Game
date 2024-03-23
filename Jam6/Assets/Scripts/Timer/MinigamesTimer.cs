using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigamesTimer : MonoBehaviour
{
    public Slider timeBar;

    float timecount = 5;

    public void TimerOut()
    {
        if (timecount > 0)
        {
            timecount -= Time.deltaTime;
            timeBar.value = timecount;
        }
    }
    void FixedUpdate()
    {
        TimerOut();
    }
}
