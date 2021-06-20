using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    // Start is called before the first frame update
    // Start Method
    void Start()
    {
        //1
        PlayerPrefs.DeleteAll();

        Debug.Log("Connecting to Photon Network");

        //2
        //roomJoinUI.SetActive(false);
        //buttonLoadArena.SetActive(false);

        //3
        //ConnectToPhoton();
    }

    void Awake()
    {
        //4 
        //PhotonNetwork.AutomaticallySyncScene = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
