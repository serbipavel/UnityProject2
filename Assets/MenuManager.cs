using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class MenuManager : MonoBehaviourPunCallbacks
{
    public void StartSinglePlayerGame()
    {
        // ��������� ����� "Village" ��� ��������� ����
        SceneManager.LoadScene("Village");

    }
    /*public void CreateRoom()
    {
        int roomName = Random.Range(0,100);
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(roomName.ToString(), roomOptions);
    }

    // Update is called once per frame
    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
       PhotonNetwork.LoadLevel("Village");
    }*/

    public void StartMultiplayerGame()
    {
        // ����������� � ���� � �������� �������
        int roomName = Random.Range(0, 100);
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(roomName.ToString(), roomOptions);
    }

    public void JoinMultiplayerGame()
    {
        // ����������� � ��������� �������
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
        // �������� ����� "Village" ��� ����������� � ����
        PhotonNetwork.LoadLevel("Village");
    }
}
