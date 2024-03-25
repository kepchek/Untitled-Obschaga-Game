using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public void Exit()
    {
        Time.timeScale = 1f;
        Application.Quit();
        Debug.Log("бб");
    }
}
