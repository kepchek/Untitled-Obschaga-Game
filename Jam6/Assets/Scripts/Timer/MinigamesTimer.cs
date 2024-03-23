using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigamesTimer : MonoBehaviour
{
    public Slider timeBar;

    public GameObject whatIsGame;

    [SerializeField] float startTimer;

    float timecount;

    void OnEnable()
    {
        timecount = startTimer;
    }

    public void TimerOut()
    {
        if (timecount > 0)
        {
            timecount -= Time.deltaTime;
            timeBar.value = timecount;
        }
        else if(timecount == 0)
        {
            switch (whatIsGame.name)
            {
                case "Minigame0":
                
                break;
            }
        }
    }
    void FixedUpdate()
    {
        TimerOut();
    }
}
