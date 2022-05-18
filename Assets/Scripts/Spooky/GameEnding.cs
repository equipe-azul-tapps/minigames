using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    private bool _isPlayerAtExit;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            _isPlayerAtExit = true;
        }
    }

    void Update()
    {
        if (_isPlayerAtExit)
            EndLevel();
    }

    void EndLevel()
    {
        SceneManager.LoadScene("SCN_Menu_Spooky");
    }
}