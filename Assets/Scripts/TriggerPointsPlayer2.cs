using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerPointsPlayer2 : MonoBehaviour
{
    public Ball ball;
    private int player2Score = 0;    
    public Text player2ScoreText;
    public Text winText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(player2Score < 2)
        {
            player2Score++;
            player2ScoreText.text = player2Score.ToString();
            ball.Start();
        }
        else
        {
            winText.text = "Player2 WIN";
            ball.GameOver();
        }
        
    }
}
