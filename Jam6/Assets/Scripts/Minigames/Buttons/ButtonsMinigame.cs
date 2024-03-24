using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonsMinigame : MonoBehaviour
{
    public GameObject gameArea;

    public GameObject MinigameTrigger4;
    private string combination;

    private string userInput = "";

    private int counter = 0;

// это объявление кнопок такое ублюдство ебаное пиздец, но у нас осталось 18 часов до конца джема так что не выёбываюсь
    public Button B1;

    public Button B2;

    public Button B3;

    public Button B4;

    public Button B5;

    public Button B6;

    public Button B7;

    public Button B8;

    public Button B9;

    public void ExitMinigame4()
    {
        counter = 0;
        userInput = "";
        gameArea.SetActive(false);
        MinigameTrigger4.GetComponent<InteractTrigger>().TriggerIsEnabled = false;

    }
    void OnEnable()
    {
        combination = "111111111";//Random.Range(100000000, 999999999).ToString();

        B1.onClick.AddListener(() => UnClick("1"));
        B2.onClick.AddListener(() => UnClick("2"));
        B3.onClick.AddListener(() => UnClick("3"));
        B4.onClick.AddListener(() => UnClick("4"));
        B5.onClick.AddListener(() => UnClick("5"));
        B6.onClick.AddListener(() => UnClick("6"));
        B7.onClick.AddListener(() => UnClick("7"));
        B8.onClick.AddListener(() => UnClick("8"));
        B9.onClick.AddListener(() => UnClick("9"));
    }
    void Update()
    {
        
    }

    public void UnClick(string letter)
    {
        userInput += letter;
        counter++;
        if(counter == 9)
        {
            if(combination == userInput)
            {
                Scores.ChangeScore(10);
                ExitMinigame4();
            }
            else
            {
                Scores.ChangeScore(-10);
                ExitMinigame4();
            }
        }
        Debug.Log(letter);
    }
}
