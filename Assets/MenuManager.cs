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
        // Загрузить сцену "Village" для одиночной игры
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
        // Подключение к сети и создание комнаты
        int roomName = Random.Range(0, 100);
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.CreateRoom(roomName.ToString(), roomOptions);
    }

    public void JoinMultiplayerGame()
    {
        // Подключение к случайной комнате
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinedRoom()
    {
        // Загрузка сцены "Village" при подключении к сети
        PhotonNetwork.LoadLevel("Village");
    }
}
