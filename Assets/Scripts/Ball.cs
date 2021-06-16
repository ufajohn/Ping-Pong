using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody_Ball;
    public float speed;
    public float acceleration;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(Random.Range(0.5f, 1), Random.Range(0.5f, 1));
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody_Ball.velocity = direction * speed;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            direction.x = -direction.x;
        }
        
        if (col.gameObject.CompareTag("Wall"))
        {
            direction.y = -direction.y;
        }

    }
}
