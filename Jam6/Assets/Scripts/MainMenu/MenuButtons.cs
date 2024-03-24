using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject tutorialPanel;
    [SerializeField] private GameObject[] descrArray;
    [SerializeField] private GameObject descrParent;

    // [SerializeField] private GameObject[] screenArray;
    // [SerializeField] private GameObject screenParent;

    [SerializeField] private Button prevBut;
    [SerializeField] private Button nextBut;

    int index = 0;

    private void Start() 
    {
        descrArray = new GameObject[5];
        // screenArray = new GameObject[5];
        for(int i = 0; i < 5; i++)
        {
            descrArray[i] = descrParent.transform.GetChild(i).gameObject;
            descrArray[i].SetActive(false);
            // screenArray[i] = screenParent.transform.GetChild(i).gameObject;
            // screenArray[i].SetActive(false);
        }


        tutorialPanel.SetActive(false);
    }

    private void Update()
    {
        if(index == 0)
        {
            prevBut.interactable = false;
        }
        else if(index == 2)
        {
            nextBut.interactable = false;
        }
        else
        {
            prevBut.interactable = true;
            nextBut.interactable = true;
        }
    }

    public void PlayButton()
    {
        Debug.Log("Игра запущена!");
        SceneManager.LoadScene(1);
    }

    public void TutorialButton()
    {
        descrArray[0].SetActive(true);
        // screenArray[0].SetActive(true);
        Debug.Log("Обучение открыто, кстати я не хочу жить");
        tutorialPanel.SetActive(true);
    }

    public void TutorialBackButton()
    {
        Debug.Log("Обучение закрыто, научился, хуле");
        tutorialPanel.SetActive(false);
    }

    public void TutorialNextGameDescription()
    {
        descrArray[index].SetActive(false);
        // screenArray[index].SetActive(false);
        index++;
        descrArray[index].SetActive(true);
        // screenArray[index].SetActive(true);

    }

    public void TutorialPrevGameDescription()
    {
        descrArray[index].SetActive(false);
        // screenArray[index].SetActive(false);
        index--;
        descrArray[index].SetActive(true);
        // screenArray[index].SetActive(true);
    }

    public void Exit()
    {
        Debug.Log("Игра закрыта");
        Application.Quit();
    }



}
