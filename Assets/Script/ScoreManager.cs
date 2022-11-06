using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;

    public BallController ball;

    public int maxScore;
    
    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBall();

        if(rightScore >= maxScore)
        {
            GameOver();
            GameOver();
        }
    }

    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.ResetBall();

        if (leftScore >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
