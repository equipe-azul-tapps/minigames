using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : Singleton<GameManager>
{

    [Header("Kart setup")]
    public int startTimer = 30; // A definir pelos GDs
    public TMP_Text timerTxt;


    [Header("Collectibles")]
    public TMP_Text scoreText;
    public int score = 0;
    public TMP_Text coinsText;
    public int coins = 0;

    public int _currentTime;

    private void Start()
    {
        StartTimer();
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

        // Chama a função imediatamente, a cada 1 segundo
        InvokeRepeating(nameof(CallTimer), 0f, 1f);
    }

    public void CallTimer()
    {
        _currentTime--;
        timerTxt.text = _currentTime.ToString(); 
    }

    #endregion
}
