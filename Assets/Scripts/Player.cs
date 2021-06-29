using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2;
    public float speed;
    PhotonView view;
    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            Vector2 direction = Vector2.zero;
            
            
                    if (Input.GetKey(KeyCode.W) && transform.position.y < 3.8){
                     direction = Vector2.up;           
                   } 

                    if (Input.GetKey(KeyCode.S) && transform.position.y > -3.8)
            {
                     direction = Vector2.down; 
                   } 

            rigidbody2.velocity = direction * 20; 

        }
   
    }
}
