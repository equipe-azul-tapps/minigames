using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{

    [Header("Debug only")]
    public int startTimer = 120; // A definir pelos GDs
    public int score = 0;
    public int coins = 0;

    private int _currentTime;

    #region Score/Coins
    public void IncreaseScore(int value)
    {
        score += value;
    }

    public void IncreaseCoins(int amount)
    {
        coins += amount;
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

    private void CallTimer()
    {
        _currentTime--;
    }

    #endregion
}
