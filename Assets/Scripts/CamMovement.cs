using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    float xMouse;
    float yMouse;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        xMouse = Input.GetAxis("Mouse X");
        yMouse = Input.GetAxis("Mouse Y");

        transform.eulerAngles += new Vector3(-yMouse, 0f, 0f);
        player.transform.eulerAngles += new Vector3(0, xMouse, 0f);

        //transform.position = player.transform.position + new Vector3(0, 1.5f, 0) - transform.forward*3; 
        transform.position = (player.transform.position + new Vector3(0, .6f, 0)) - transform.forward * 3;

    }
}
