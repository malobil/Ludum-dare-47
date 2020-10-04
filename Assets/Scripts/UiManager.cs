using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager Instance { get; private set; }
    [SerializeField] GameObject m_pauseMenu;
    [SerializeField] private GameObject m_gameOver;
    [SerializeField] private TextMeshProUGUI m_gameOverPoint;
    [SerializeField] TextMeshProUGUI m_pointText ;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void ShowPauseMenu(bool value)
    {
        m_pauseMenu.SetActive(value);
    }

    public void RestartGame()
    {
        GameManager.Instance.RestartLevel();
        Time.timeScale = 1f;
    }

    public void GoBackToTheMenu()
    {
        GameManager.Instance.RestartGame();
        Time.timeScale = 1f;
    }

    public bool PauseMenuState()
    {
        return m_pauseMenu.active;
    }

    public void UpdatePoints(int newPoints)
    {
        m_pointText.text = newPoints.ToString("");
    }

    public void ShowGameOver()
    {
        m_gameOverPoint.text = GameManager.Instance.GetCurrentPoint().ToString("");
        Time.timeScale = 0f;
        m_gameOver.SetActive(true);
    }
}
