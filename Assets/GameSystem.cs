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
        
        // ���������, ���������� �� �� � ����
        if (PhotonNetwork.IsConnected)
        {
            // ���� ����������, ���������� ����� ����� PhotonNetwork
            PhotonNetwork.Instantiate(player.name, transform.position, Quaternion.identity);
        }
        else
        {
            // ���� �� ����������, ������� ������ ��������
            Instantiate(player, transform.position, Quaternion.identity);
        }
    }


}
