using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    [Header("Audio")]
    public AudioClip winSound;

    private bool _isPlayerAtExit;
    private Coroutine _endingGame = null;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            _isPlayerAtExit = true;
        }
    }

    void Update()
    {
        if (_isPlayerAtExit && _endingGame == null)
            _endingGame = StartCoroutine(EndLevel());
    }

    IEnumerator EndLevel()
    {
        GameManager.instance.audioController.ToqueSFX(winSound);
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("SCN_Menu_Spooky");
    }
}