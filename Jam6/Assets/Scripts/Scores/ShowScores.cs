using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowScores : MonoBehaviour
{
    int finalScore;    
    [SerializeField] TMP_Text Text;
    void Start()
    {
        finalScore = Scores.GetScore();
        if(GameObject.Find("EndWinMenu"))
        {
            Text.text = $"{finalScore}";
        }
        else
        {
            Text.text = $"{finalScore}";
        }
    }
}
