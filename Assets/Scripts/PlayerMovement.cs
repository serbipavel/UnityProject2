using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*float xMove;
    float zMove;*/
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] int numOfJumps = 2;

    [SerializeField] GameObject maincamera;
    //Animator anim;
    PhotonView view;
    
    // Start is called before the first frame update
    void Start()
    {
       view = GetComponent<PhotonView>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!view.IsMine) return;
        //������ 3 (� ����������)
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movement += Camera.main.transform.forward;
            /*anim.SetBool("IsIdle",false);
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsRunning", false);*/
        }
            

        if (Input.GetKey(KeyCode.S))
        {
            movement -= Camera.main.transform.forward;
            /*anim.SetBool("IsIdle", false);
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsRunning", false);*/
        }
            
        if (Input.GetKey(KeyCode.A))
        {
            movement -= Camera.main.transform.right;
            /*anim.SetBool("IsIdle", false);
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsRunning", false);*/
        }
            
        if (Input.GetKey(KeyCode.D))
        {
            movement += Camera.main.transform.right;
            /*anim.SetBool("IsIdle", false);
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsRunning", false);*/
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10f;
            /*anim.SetBool("IsIdle", false);
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsRunning", true);*/
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 5f;
            /*anim.SetBool("IsIdle", false);
            anim.SetBool("IsWalking", true);
            anim.SetBool("IsRunning", false);*/
        }


        movement.Normalize();

        /*rb.velocity = new Vector3(xMove*speed, 0, zMove*speed);*/
        rb.velocity = new Vector3(movement.x*speed, rb.velocity.y,movement.z*speed);
       /* if (!Input.GetKey(KeyCode.W) &&
            !Input.GetKey(KeyCode.A) &&
            !Input.GetKey(KeyCode.S) &&
            !Input.GetKey(KeyCode.D) &&
            !Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("IsIdle", true);
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsRunning", false);
        }*/
        
        
        if (Input.GetKeyDown(KeyCode.Space) && numOfJumps>0)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            numOfJumps--;
        }
            
    }
    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.transform.tag == "Ground")
            numOfJumps = 2;*/
        numOfJumps = 2;
    }
}
