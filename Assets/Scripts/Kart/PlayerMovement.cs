using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 10f;
    public float turnSpeed = 10f;
   // private Rigidbody playerRb;   
    public TMP_Text stamina;
    public bool gameOver = false;




    void Start()
    {
       //playerRb = GetComponent<Rigidbody>();
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

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
       
      
    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.transform.tag == "Finish")
        {
            SceneManager.LoadScene("SCN_Menu");
        }
    }

   
}
