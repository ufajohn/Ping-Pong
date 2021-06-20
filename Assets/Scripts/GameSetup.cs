using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class GameSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate(Path.Combine("", "Player"), new Vector3(8.5f, 0, 0), Quaternion.identity);
        }
        else
        {
            PhotonNetwork.Instantiate(Path.Combine("", "Player"), new Vector3(-8.5f, 0, 0), Quaternion.identity);
        }
    }

   
}
