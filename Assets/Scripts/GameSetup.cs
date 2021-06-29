using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;
using UnityEngine.UI;

public class GameSetup : MonoBehaviour
{
    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate("Player", new Vector3(8.5f, 0, 0), Quaternion.identity);
        }
        else
        {
            PhotonNetwork.Instantiate("Player", new Vector3(-8.5f, 0, 0), Quaternion.identity);
        }
    }  

}
