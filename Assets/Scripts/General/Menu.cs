using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject creditsScreen;

    public void PlaySpooky()
    {
        SceneManager.LoadScene(3);
    }

    public void PlayKart()
    {
        SceneManager.LoadScene(4);
    }

    public void ShowCredits()
    {
        StartCoroutine(DisplayScreen());
    }

    IEnumerator DisplayScreen()
    {
        creditsScreen.SetActive(true);
        yield return new WaitForSeconds(2f);
        creditsScreen.SetActive(false);

    }
}
