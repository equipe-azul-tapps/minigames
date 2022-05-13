using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject[] obs;
    //private int rnd;
    public GameObject menuGameOver;
    private GameManager gameManager;
    void Start()
    {
        //gameManager = GetComponent<GameManager>;
        menuGameOver.SetActive(false);
        InvokeRepeating("EndGame", 2, 5);
        //rnd = Random.Range(0, 3);
        //Instantiate(obs[rnd]);
    }

    // Update is called once per frame
    void Update()
    {
        //if(gameManager._currentTime <= 0)
        //{
        //    menuGameOver.SetActive(true);
        //    SceneManager.LoadScene("SCN_Menu");

        //}
        
    }
    void EndGame()
    {
        if(menuGameOver.activeInHierarchy)
        {
            SceneManager.LoadScene("SCN_Menu");
        }
    }

}
