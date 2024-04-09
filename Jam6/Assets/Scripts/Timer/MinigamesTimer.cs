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

    static float static_startTimer;

    static float static_timercount; // крч эта хуета мне нужна чтобы передавать значение таймера в другие скрипты через метод

    // void Awake()
    // {
    //     game = GameObject.Find("Router Canvas");
    // }

    void OnEnable()
    {
        timecount = startTimer;
        timeBar.interactable = false;
        timeBar.maxValue = startTimer;

        static_startTimer = startTimer;
    }


    public void TimerOut()
    {
        if (timecount > 0)
        {
            timecount -= Time.deltaTime;
            static_timercount = timecount;
            timeBar.value = timecount;
        }
        else
        {
            Debug.Log("timer 0");
            switch (whatIsGame.name)
            {
                case "Minigame0":
                    Debug.Log(whatIsGame.name);
                    Scores.ChangeScore(-25);
                    GameObject.Find("Router Canvas").GetComponent<Router>().ExitMinigame0();
                    break;
                case "Minigame1":
                    Debug.Log(whatIsGame.name);
                    Scores.ChangeScore(-35);
                    GameObject.Find("BasketGreen").GetComponent<ItemSlot>().ExitMinigame1(); // тут в кавычках название не канваса, а одной из карзин. не спрашивай, я сам знаю чтоо это пиздец
                    break;
                case "Minigame2":
                    Debug.Log(whatIsGame.name);
                    Scores.ChangeScore(-65);
                    GameObject.Find("VodkaPlayer").GetComponent<MovingSquare>().ExitMinigame2();
                    break;
                case "Minigame3":
                    Debug.Log(whatIsGame.name);
                    Scores.ChangeScore(-22);
                    GameObject.Find("Studies Canvas").GetComponent<Clicker>().ExitMinigame3();
                    break;
                case "Minigame4":
                    Debug.Log(whatIsGame.name);
                    Scores.ChangeScore(-35);
                    GameObject.Find("ButtonsGame Canvas").GetComponent<ButtonsMinigame>().ExitMinigame4();
                    break;
            }
        }
    }
    void FixedUpdate()
    {
        TimerOut();
    }

    public static float GetTimerValue()
    {
        if(static_timercount > static_startTimer * 0.7)
        {
            return 1.5f;
        }
        else if(static_timercount > static_startTimer * 0.5)
        {
            return 1.3f;
        }
        else
        {
            return 1;
        }
    }
}
