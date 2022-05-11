using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //// Start is called before the first frame update
    //private Rigidbody playerRb;
    //private float speed = 10f;

    //void Start()
    //{
    //    playerRb = GetComponent<Rigidbody>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    MovePlayer();
    //}
    //void MovePlayer()
    //{
    //    float horizontalInput = Input.GetAxis("Horizontal");
    //    //float verticalInput = Input.GetAxis("Vertical");

    //    playerRb.AddForce(Vector3.left * speed * horizontalInput);
    //    playerRb.AddForce(Vector3.right * speed * horizontalInput);
    //}
    public float speed = 50f;
    private float zBound = 6f;
    private Rigidbody playerRb;
    public bool teste;


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        //ConstrainMovement();
    }
    //Player Movement
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
       
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    //Avoid the player goin off the top or bottom of the screen
    void ConstrainMovement()
    {
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
