using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigamesTimer : MonoBehaviour
{
    public Slider timeBar;

    public GameObject whatIsGame;

    // public GameObject game;

    [SerializeField] float startTimer;

    float timecount;

    // void Awake()
    // {
    //     game = GameObject.Find("Router Canvas");
    // }

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
        else
        {
            Debug.Log("timer 0");
            switch (whatIsGame.name)
            {
                case "Minigame0":
                Debug.Log(whatIsGame.name);
                GameObject.Find("Router Canvas").GetComponent<Router>().ExitMinigame0();
                break;
                case "Minigame1":

                break;
            }
        }
    }
    void FixedUpdate()
    {
        TimerOut();
    }
}
