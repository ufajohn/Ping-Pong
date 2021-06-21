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
    public Text player1ScoreText;
    public Text player2ScoreText;
    public Text matchOver;
    private int player1Score = 0;
    private int player2Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));
        speed = 2;
        acceleration = 1.1f;
        transform.position = Vector2.zero;       
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody_Ball.velocity = direction.normalized * speed;

        if (player1Score < 21 & player2Score < 21)
        {
            if (transform.position.x > 8.5)
            {
                player1Score++;
                player1ScoreText.text = player1Score.ToString();
                Start();
            }

            if (transform.position.x < -8.5)
            {
                player2Score++;
                player2ScoreText.text = player2Score.ToString();
                Start();
            }
        }

        else
        {
            matchOver.text = "Матч закончен!";
            speed = 0;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Player")){
            direction.x = -direction.x;
            speed *= acceleration;
        }
         if(col.gameObject.CompareTag("Wall")){
            direction.y = -direction.y;
        }
        /*if(col.gameObject.CompareTag("Side")){
            direction.x = -direction.x;
        }*/

    }
}
