using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;


public class MenuManager : MonoBehaviourPunCallbacks

{
    public InputField createInput;
    public InputField joinInput;
    public string playerName;
    public string roomName;
    public Text playerStatus;
    private TypedLobby sqlLobby = new TypedLobby("customSqlLobby", LobbyType.SqlLobby);
    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;
        PhotonNetwork.CreateRoom(createInput.text, roomOptions);
    }
    private void GetCustomRoomList(string sqlLobbyFilter)
            {
                PhotonNetwork.GetCustomRoomList(sqlLobby, sqlLobbyFilter);
            }

    
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
            {
        // here you get the response, empty list if no rooms found
        Debug.Log(roomList);
        Debug.Log(sqlLobby);
    }

  public void JoinRoom()
      {
          if (PhotonNetwork.IsConnected)
        {
             PhotonNetwork.JoinRoom(joinInput.text);
        }
      }

      

    public override void OnJoinedRoom()
    {
        

        if (PhotonNetwork.CurrentRoom.PlayerCount > 1)
        {
            PhotonNetwork.LoadLevel("GameScene");
        }
        else
        {
            playerStatus.text = "Minimum 2 Players required to Load Arena!";
        }
    }

}
