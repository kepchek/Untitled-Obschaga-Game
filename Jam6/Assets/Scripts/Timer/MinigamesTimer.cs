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
        timeBar.interactable = false;
        timeBar.maxValue = startTimer;
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
                    Scores.ChangeScore(-10);
                    GameObject.Find("Router Canvas").GetComponent<Router>().ExitMinigame0();
                    break;
                case "Minigame1":
                    Debug.Log(whatIsGame.name);
                    Scores.ChangeScore(-20);
                    GameObject.Find("Trash").GetComponent<ItemSlot>().ExitMinigame1();
                    break;
                case "Minigame2":
                    Debug.Log(whatIsGame.name);
                    Scores.ChangeScore(-50);
                    GameObject.Find("FishPlayer").GetComponent<MovingSquare>().ExitMinigame2();
                    break;
                case "Minigame3":
                    Debug.Log(whatIsGame.name);
                    Scores.ChangeScore(-7);
                    GameObject.Find("Studies Canvas").GetComponent<Clicker>().ExitMinigame3();
                    break;
                case "Minigame4":
                    Debug.Log(whatIsGame.name);
                    Scores.ChangeScore(-20);
                    GameObject.Find("ButtonsGame Canvas").GetComponent<ButtonsMinigame>().ExitMinigame4();
                    break;
            }
        }
    }
    void FixedUpdate()
    {
        TimerOut();
    }
}
