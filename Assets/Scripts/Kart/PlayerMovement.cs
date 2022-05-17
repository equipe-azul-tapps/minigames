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
    private AudioSource playerAudio;
    public AudioClip[] foodSound;
    public AudioClip[] coinSound;
    public AudioClip[] crashSound;
    private int rn;
    public AudioClip timerSound;




    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
       //playerRb = GetComponent<Rigidbody>();
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
    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.transform.tag == "Finish")
        {
            SceneManager.LoadScene("SCN_Menu");
        }
        if(other.gameObject.CompareTag("Coin"))
        {
            playerAudio.PlayOneShot(coinSound[rn], 1.0f);
        }
        if (other.gameObject.CompareTag("Stamina"))
        {
            playerAudio.PlayOneShot(foodSound[rn], 1.0f);
        }
        if (other.gameObject.CompareTag("Timer"))
        {
            playerAudio.PlayOneShot(timerSound, 1.0f);
        }
       

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            playerAudio.PlayOneShot(crashSound[rn], 1.0f);
        }
    }



}
