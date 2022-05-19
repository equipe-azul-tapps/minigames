using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject creditsScreen;

    public void PlaySpooky()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayKart()
    {
        SceneManager.LoadScene(2);
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
