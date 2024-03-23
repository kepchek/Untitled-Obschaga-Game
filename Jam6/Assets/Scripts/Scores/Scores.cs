using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Scores : MonoBehaviour
{
    static int ScoreCount;

    public TMP_Text score;
    void Start()
    {
        ScoreCount = 0;
    }

    void Update()
    {
        score.text = ScoreCount.ToString();
    }

    public static int ChangeScore(int score)
    {
        ScoreCount += score;
        return ScoreCount;
    }
}
