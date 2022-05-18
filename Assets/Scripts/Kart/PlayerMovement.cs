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
    private AudioSource playerSound;
    public AudioClip[] crashSound;
    public AudioClip[] foodSounds;
    public AudioClip[] coinSounds;
    public AudioClip timerSound;
    private int rn;
    private float xRange = 5.4f;




    void Start()
    {
       playerSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rn = Random.Range(0, 2);
        MovePlayer();
        
    }
    //Player Movement
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }



    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.transform.tag == "Finish")
        {
            SceneManager.LoadScene("SCN_Menu");
        }
        if (other.transform.tag == "Stamina")
        {
            playerSound.PlayOneShot(foodSounds[rn], 1.0f);
        }
        if (other.transform.tag == "Coin")
        {
            playerSound.PlayOneShot(coinSounds[rn], 1.0f);
        }
        if (other.transform.tag == "Timer")
        {
            playerSound.PlayOneShot(timerSound, 1.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Object")
        {
            playerSound.PlayOneShot(crashSound[rn], 1.0f);
        }
    }


}
