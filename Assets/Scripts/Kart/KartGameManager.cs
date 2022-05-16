using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class KartGameManager : MonoBehaviour
{
    [Header("Kart setup")]
    public PlayerMovement playerMovement;
    public int startTimer = 30;
    public TMP_Text timerTxt;

    [Header("Collectibles")]
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

    #region Timer
    public void StartTimer()
    {
        // Inicializa o timer
        _currentTime = startTimer;

        // Chama a fun??o imediatamente, a cada 1 segundo
        InvokeRepeating(nameof(CallTimer), 0f, 1f);
    }

    public void CallTimer()
    {
        if (timerTxt != null)
        {
            _currentTime--;
            if (_currentTime <= 0)
            {
                SceneManager.LoadScene("SCN_Menu");
            }
            timerTxt.text = _currentTime.ToString();
        }
    }

    #endregion

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
