using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerPointsPlayer1 : MonoBehaviour
{
    public Ball ball;
    private int player1Score = 0;    
    public Text player1ScoreText;
    public Text winText;
     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(player1Score < 2)
        {
            player1Score++;
            player1ScoreText.text = player1Score.ToString();
            ball.Start();
        }
        else
        {
            winText.text = "Player1 WIN";
            ball.GameOver();
        }
       
       
    }
}
