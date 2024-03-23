using System;
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
    int randomMGvalue; //Случайный выбор числа, для выбора миниигры


    private void Awake() 
    {
        randomMGvalue = UnityEngine.Random.Range(0, 22);
        Debug.Log(randomMGvalue);
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

    public void StartMinigame0()
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

    void RandomMethodInvoke()
    {
        /*
        Ценность игр
        Кликер - 6
        Роутер - 5
        Провода - 4
        Носки - 4
        Водка - 2

        */
        if((randomMGvalue > 0) & (randomMGvalue <= 6)) //Выбор миниигры посредством случайного числа и ценности миниигры
        {
            //кликер
        }
        else if((randomMGvalue > 6) & (randomMGvalue <= 11))
        {
            //роутер
        }
        else if((randomMGvalue > 11) & (randomMGvalue <= 15))
        {
            //провода
        }
        else if((randomMGvalue > 15) & (randomMGvalue <= 19))
        {
            //носки
        }
        else if((randomMGvalue > 19) & (randomMGvalue <= 21))
        {
            //водка
        }

    }

    /*
    public void ExitMinigame0()
    {
        MinigameTrigger0.GetComponent<InteractTrigger>().TriggerIsEnabled = false;
    }
    */


}
