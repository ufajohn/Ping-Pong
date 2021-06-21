using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    private Text connectionStatus;
    private object roomJoinUI;
    private object buttonLoadArena;
    private string playerName;
    private string roomName;
    private string gameVersion = "1";

    void Start()
    {
        PlayerPrefs.DeleteAll();
        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }
    void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Menu");    
    }
       

}
