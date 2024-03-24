using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MinigameSystem : MonoBehaviour
{
    //Создаём переменные объектов-триггеров
    public GameObject MinigameTrigger0; 
    public GameObject MinigameTrigger1;
    public GameObject MinigameTrigger2;
    public GameObject MinigameTrigger3;
    public GameObject MinigameTrigger4;
    int randomMGvalue; //Случайный выбор числа, для выбора миниигры
    public float minDelay = 10f;
    public float maxDelay = 20.1f;
    public float delayDecrease = 0.1f;
    


    private void Awake() 
    {
        //Находим и присваиваем значения объектам-триггерам
        MinigameTrigger0 = GameObject.Find("MinigameTrigger0");
        MinigameTrigger1 = GameObject.Find("MinigameTrigger1");
        MinigameTrigger2 = GameObject.Find("MinigameTrigger2");
        MinigameTrigger3 = GameObject.Find("MinigameTrigger3");
        MinigameTrigger4 = GameObject.Find("MinigameTrigger4");
    }
    private void Start() 
    {
        StartCoroutine(RandomMethodInvoke());    
    }
    

 //МЕТОД ДЛЯ ТЕСТА
    private void Update() {
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartMinigame0();
            Debug.Log("Minigame ready!");
        }
        
    }
    //Запускаем готовноость начать миниигру
    //Необходимо перекинуть это говнище в корутин
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

    IEnumerator RandomMethodInvoke()
    {
        /*
        Ценность игр
        Кликер - 6
        Роутер - 5
        Провода - 4
        Носки - 4
        Водка - 2

        */
        float delay = UnityEngine.Random.Range(minDelay, maxDelay);//Создаём переменную плавающей задержки
        while (true)
        {
            randomMGvalue = UnityEngine.Random.Range(0, 22); //СВыбираем рандомный минигейм согласно таблице ценностей
            Debug.Log(randomMGvalue);
            if((randomMGvalue >= 0) & (randomMGvalue <= 6)) //Выбор миниигры посредством случайного числа и ценности миниигры
            {
                //кликер
                Debug.Log("Кликер");
            }
            else if((randomMGvalue > 6) & (randomMGvalue <= 11))
            {
                //роутер
                Debug.Log("Роутер");
            }
            else if((randomMGvalue > 11) & (randomMGvalue <= 15))
            {
                //провода
                Debug.Log("Провода");
            }
            else if((randomMGvalue > 15) & (randomMGvalue <= 19))
            {
                //носки
                Debug.Log("Носки");
            }
            else if((randomMGvalue > 19) & (randomMGvalue <= 21))
            {   
                //водка
                Debug.Log("Водка");
            }
            yield return new WaitForSeconds(delay);
            delay = Mathf.Max(minDelay, delay - delayDecrease); //Уменьшаем задержку с каждым циклом для нарастания хардкорности
        }

        

    }


    /*
    public void ExitMinigame0()
    {
        MinigameTrigger0.GetComponent<InteractTrigger>().TriggerIsEnabled = false;
    }
    */


}
