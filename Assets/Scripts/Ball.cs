using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody_Ball;
    public float speed;
    public float acceleration;
    Vector2 direction;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));
        speed = 4;
        acceleration = 1.2f;
        transform.position = Vector2.zero;       
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody_Ball.velocity = direction.normalized * speed;
          
          if(transform.position.x > player.transform.position.x + 1){
            Debug.Log("Вы проиграли!");
             Start();
        }
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("Player")){
            direction.x = -direction.x;
            speed = speed * acceleration;
        }
         if(col.gameObject.CompareTag("Wall")){
            direction.y = -direction.y;
        }
        if(col.gameObject.CompareTag("Side")){
            direction.x = -direction.x;
        }

    }
}
