using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject player;
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
