using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SpookyGameManager : MonoBehaviour
{
    [Header("Spooky setup")]
    public GameObject player;
    public GameObject lostScreen;

    [Header("Collectibles")]
    public TMP_Text coinsText;
    public int coins = 0;

    public int _currentTime;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        UpdateCoins();
    }

    #region Coins
    public void IncreaseCoins(int amount)
    {
        coins += amount;
    }

    private void UpdateCoins()
    {
        if (coinsText != null)
        {
            coinsText.text = $"Coins: {coins}";
        }
    }

    #endregion

    public void ShowLostScreen()
    {
        Time.timeScale = 0;
        lostScreen.SetActive(true);
    }

    #region Menu
    public void Retry()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void ExitMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    #endregion
}
