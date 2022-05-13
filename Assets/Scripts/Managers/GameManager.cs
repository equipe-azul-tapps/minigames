using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : Singleton<GameManager>
{

    [Header("Kart setup")]
    public int startTimer = 30; // A definir pelos GDs
    public TMP_Text timerTxt;


    [Header("Spooky setup")]
    public GameObject player;
    public GameObject lostScreen;

    [Header("Collectibles")]
    public TMP_Text scoreText;
    public int score = 0;
    public TMP_Text coinsText;
    public int coins = 0;

    public int _currentTime;

    private void Start()
    {
        StartTimer();
        Time.timeScale = 1;
    }

    private void Update()
    {
        UpdateScore();
        UpdateCoins();
    }

    #region Score/Coins
    public void IncreaseScore(int value)
    {
        score += value;
    }

    private void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {score}";
        }
    }

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

    #region Timer
    public void StartTimer()
    {
        // Inicializa o timer
        _currentTime = startTimer;

        // Chama a fun��o imediatamente, a cada 1 segundo
        InvokeRepeating(nameof(CallTimer), 0f, 1f);
    }

    public void CallTimer()
    {
        if (timerTxt != null)
        {
            _currentTime--;
            timerTxt.text = _currentTime.ToString();
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
