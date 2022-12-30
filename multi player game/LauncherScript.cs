using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LauncherScript: MonoBehaviourPunCallbacks {
    public PhotonView playerPrefab;
    void Start()
    {
      PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
      Debug.Log("connected to Master");
      PhotonNetwork.JoinRandomOrCreateRoom();
    }
    public override void OnJoinedRoom() {
        Debug.Log("Joined the room successfully");
        PhotonNetwork.Instantiate(playerPrefab.name, Vector3.zero, Quaternion.identity);

    }
}