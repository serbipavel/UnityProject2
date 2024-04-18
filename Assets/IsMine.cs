using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class IsMine : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private CamMovement _camMovement;
    [SerializeField] private GameObject _camera;
    private PhotonView photonView;
    void Start()
    {
        /*photonView = GetComponent<PhotonView>();
        if (!photonView.IsMine)
        {
            _playerMovement.enabled = false;
            _camMovement.enabled = false;
            _camera.SetActive(false);
        }*/

        photonView = GetComponent<PhotonView>();

        if (PhotonNetwork.IsConnected)
        {
            // Если подключены к сети, проверяем, является ли объект локальным игроком
            if (!photonView.IsMine)
            {
                // Если объект не принадлежит текущему игроку, отключаем его управление
                DisableControls();
            }
        }
        else
        {
            // Если не подключены к сети (одиночная игра), разрешаем управление всем объектам
            EnableControls();
        }
    }

    private void DisableControls()
    {
        _playerMovement.enabled = false;
        _camMovement.enabled = false;
        _camera.SetActive(false);
    }

    private void EnableControls()
    {
        _playerMovement.enabled = true;
        _camMovement.enabled = true;
        _camera.SetActive(true);
    }
}
