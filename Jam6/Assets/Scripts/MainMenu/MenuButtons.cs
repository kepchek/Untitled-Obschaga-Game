using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject tutorialPanel;

    private void Start() 
    {
        tutorialPanel.SetActive(false);
    }

    public void PlayButton()
    {
        Debug.Log("Игра запущена!");
        SceneManager.LoadScene(1);
    }

    public void TutorialButton()
    {
        Debug.Log("Обучение открыто, кстати я не хочу жить");
        tutorialPanel.SetActive(true);
    }

    public void TutorialBackButton()
    {
        Debug.Log("Обучение закрыто, научился, хуле");
        tutorialPanel.SetActive(false);
    }

    public void Exit()
    {
        Debug.Log("Игра закрыта");
        Application.Quit();
    }



}
