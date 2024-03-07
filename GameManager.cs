using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Caiden Herbert

public class GameManager : MonoBehaviour
{
    Score score;
    Ball ball;
    void Start() 
    {
        ball = FindObjectOfType<Ball>();
        score = FindObjectOfType<Score>();
    }
    public void ScoreChanged(int 1, int 2) 
    {
        if(Score.IncreaseScore) {
            RestartGame();
        }
        Ball.ResetBallPosition();
    }
    void RestartGame()
    {
        Score.ResetScore();
        Ball.ResetBallPostion();
    }
}