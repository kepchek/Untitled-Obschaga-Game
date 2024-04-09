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
    public float minDelay = 1f;
    public float maxDelay = 5f;
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
    // private void Update() {
    //     if(Input.GetKeyDown(KeyCode.R))
    //     {
    //         StartMinigame0();
    //         Debug.Log("Minigame ready!");
    //     }
    // }
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

        const float delay = 6f; // Задержка 6 секунд

        while (true)
        {
            randomMGvalue = UnityEngine.Random.Range(0, 24); //Выбираем рандомный минигейм согласно таблице ценностей
            Debug.Log($"Случайное число - {randomMGvalue}");

            if((randomMGvalue >= 0) & (randomMGvalue <= 5)) //Выбор миниигры посредством случайного числа и ценности миниигры
            {
                StartMinigame3();
                Debug.Log("Кликер");
            }
            else if((randomMGvalue > 5) & (randomMGvalue <= 10))
            {
                StartMinigame0();
                Debug.Log("Роутер");
            }
            else if((randomMGvalue > 10) & (randomMGvalue <= 15))
            {
                StartMinigame4();
                Debug.Log("Удлинитель бля");
            }
            else if((randomMGvalue > 15) & (randomMGvalue <= 20))
            {
                StartMinigame1();
                Debug.Log("Носки");
            }
            else if((randomMGvalue > 20) & (randomMGvalue <= 24))
            {
                StartMinigame2();
                Debug.Log("Водка");
            }

            yield return new WaitForSeconds(delay);
        }
    }
}





