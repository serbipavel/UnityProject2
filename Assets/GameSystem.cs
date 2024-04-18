using Newtonsoft.Json.Linq;
using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = System.Random;

public class GameSystem : MonoBehaviourPunCallbacks
{
    [SerializeField] public GameObject player;
    void Start()
    /*{
        PhotonNetwork.Instantiate(player.name, transform.position, Quaternion.identity);
    }*/
    {
        
        // Проверяем, подключены ли мы к сети
        if (PhotonNetwork.IsConnected)
        {
            // Если подключены, используем спаун через PhotonNetwork
            PhotonNetwork.Instantiate(player.name, transform.position, Quaternion.identity);
        }
        else
        {
            // Если не подключены, создаем игрока локально
            Instantiate(player, transform.position, Quaternion.identity);
        }
    }


}
