using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 0.05f;
    public float forwardSpeed = 50f;
    private float zBound = 6f;
    private Rigidbody playerRb;
    public bool teste;
    public TMP_Text stamina;
    public bool gameOver = false;




    void Start()
    {
       playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        
    }
    //Player Movement
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(0, 0, horizontalInput);
        transform.Translate(-speed, 0, 0);
       
        //playerRb.AddForce(Vector3.forward * speed * horizontalInput);
        //playerRb.AddForce(Vector3.left * speed );
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Stamina")
        {
            speed += 0.01f;
            Destroy(other.gameObject);
            Debug.Log("Acelerou");
        }
        if (other.transform.tag == "Timer")
        {
            GameManager.instance._currentTime += 10;
            Destroy(other.gameObject);
            Debug.Log("Mais tempo");
        }
    }

    ////Avoid the player goin off the top or bottom of the screen
    //void ConstrainMovement()
    //{
    //    if (transform.position.z < -zBound)
    //    {
    //        transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
    //    }
    //    if (transform.position.z > zBound)
    //    {
    //        transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
    //    }
    //}
}
