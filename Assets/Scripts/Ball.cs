using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody_Ball;
    public float speed;
    public float acceleration;
    Vector2 direction;
    public Player player;    
    public Text matchOver;
    int points = 0;
    public Text playerScoreText;

    // Start is called before the first frame update
    public void Start()
    {
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));
        speed = 2;
        acceleration = 1.5f;
        transform.position = Vector2.zero;       
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody_Ball.velocity = direction.normalized * speed;

           /* if (transform.position.x > 8.9)
            {
                Start();
                player1Score++;
                player1ScoreText.text = player1Score.ToString();
                
            }

            if (transform.position.x < -8.9)
            {
                Start();
                player2Score++;
                player2ScoreText.text = player2Score.ToString();
                
            }
        

        else
        {
            matchOver.text = "Матч закончен!";
            speed = 0;
        }*/
        
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Player")){
            direction.x = -direction.x;
            speed *= acceleration;
            points++;
            playerScoreText.text = points.ToString();

        }
         if(col.gameObject.CompareTag("Wall")){
            direction.y = -direction.y;
        }
        if(col.gameObject.CompareTag("Side")){
            direction.x = -direction.x;
        }

    }
    public void GameOver()
    {
        speed = 0;
    }
}
