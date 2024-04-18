using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class VillagePlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    public float minX, minY, minZ, maxX, maxY, maxZ;

    void SpawnPlayerOnStart() // ��������������� ����� Start() � SpawnPlayerOnStart()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));

        // ���������, ��������� �� � ���� ��� ���
        if (PhotonNetwork.IsConnected)
        {
            // ���� ��������� � ����, ���������� ����� ����� PhotonNetwork
            PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        }
        else
        {
            // ���� �� ��������� � ����, ������� ������ ��������
            Instantiate(playerPrefab, randomPosition, Quaternion.identity);
        }
    }
}
