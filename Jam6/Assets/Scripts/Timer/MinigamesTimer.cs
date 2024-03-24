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
                    Debug.Log(whatIsGame.name);
                    GameObject.Find("Trash").GetComponent<ItemSlot>().ExitMinigame1();
                    break;
                case "Minigame2":
                    Debug.Log(whatIsGame.name);
                    GameObject.Find("Fishing Canvas").GetComponent<MovingSquare>().ExitMinigame2();
                    break;
                case "Minigame3":
                    Debug.Log(whatIsGame.name);
                    GameObject.Find("Studies Canvas").GetComponent<Clicker>().ExitMinigame3();
                    break;
            }
        }
    }
    void FixedUpdate()
    {
        TimerOut();
    }
}
