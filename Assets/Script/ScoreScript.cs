using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject score;
    GameObject block;
    static int totalScore = 0;
    public static ScoreScript instance; 
    void Start()
    {
        this.score = GameObject.Find("Score");
    }

    // Update is called once per frame
    public void ScrerManager(int score)
    {
        totalScore += score;
        this.score.GetComponent<Text>().text = totalScore.ToString();
    }
}
