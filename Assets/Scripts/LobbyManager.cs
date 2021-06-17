using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LobbyManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.NickName = "Player" + Random.Range(11, 99);
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
