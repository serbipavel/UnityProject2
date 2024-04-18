using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    // Start is called before the first frame update

    /*public GameObject player;
    public float minX, minY, minZ, maxX, maxY, maxZ;
    
    void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(player.name, randomPosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    public GameObject playerPrefab;
    public float minX, minY, minZ, maxX, maxY, maxZ;

    void Start()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));

        // Проверяем, подключен ли к сети или нет
        if (PhotonNetwork.IsConnected)
        {
            // Если подключен к сети, используем спаун через PhotonNetwork
            PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        }
        else
        {
            // Если не подключен к сети, создаем игрока локально
            Instantiate(playerPrefab, randomPosition, Quaternion.identity);
        }
    }

    void Update()
    {

    }
}
