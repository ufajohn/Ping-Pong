using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using Photon.Pun;
using System;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    [SerializeField]
    GameObject findMatchbtn;
    [SerializeField]
    GameObject searchingPanel;
    [SerializeField]
    GameObject loadingText;
    [SerializeField]
    GameObject observer;

    private void Start()
    {
        searchingPanel.SetActive(false);
        findMatchbtn.SetActive(false);
        observer.SetActive(false);
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log(PhotonNetwork.CloudRegion + " server");
        PhotonNetwork.AutomaticallySyncScene = true;
        findMatchbtn.SetActive(true);
        observer.SetActive(true);
        loadingText.SetActive(false);
    }
    public void FindMatch()
    {
        searchingPanel.SetActive(true);
        findMatchbtn.SetActive(false);
        observer.SetActive(false);
        PhotonNetwork.JoinRandomRoom();
    }
    public void Observer()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2 && PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.LoadLevel("GameScene");
        }
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        MakeRoom();
    }

    void MakeRoom()
    {
        int randomRoomName = UnityEngine.Random.Range(0, 5000);
        RoomOptions roomOptions = new RoomOptions()
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = 2
        };
        PhotonNetwork.CreateRoom("RoomName_" + randomRoomName, roomOptions);
        Debug.Log("комната создана, ждем второго игрока");
    }

    public void StopSearch()
    {
        searchingPanel.SetActive(false);
        findMatchbtn.SetActive(true);
        observer.SetActive(true);
        PhotonNetwork.LeaveRoom();
    }
    public override void OnPlayerEnteredRoom(Photon.Realtime.Player newPlayer)
    {
        if(PhotonNetwork.CurrentRoom.PlayerCount == 2 && PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.LoadLevel("GameScene");
        }
    }
}
