using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject player;
    void Start()
    {
        PhotonNetwork.Instantiate(player.name, transform.position, Quaternion.identity);
    }

   
}
