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
    [SerializeField] TextMeshProUGUI m_tourCounter ;

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

    private void Start()
    {
        Cursor.visible = false;
    }

    public void ShowPauseMenu(bool value)
    {
        if(value)
        {
            PlayerInputManager.Instance.DisableInputs();
            Time.timeScale = 0;
            Cursor.visible = true;
        }
        else
        {
            PlayerInputManager.Instance.EnableInputs();
            Time.timeScale = 1;
            Cursor.visible = false;
        }
        
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
        Cursor.visible = true;
        PlayerInputManager.Instance.DisableInputs();
        m_gameOverPoint.text = GameManager.Instance.GetCurrentPoint().ToString("");
        Time.timeScale = 0f;
        m_gameOver.SetActive(true);
    }

    public void UpdateTourCounter(int currentTour, int maxTour)
    {
        m_tourCounter.text = string.Format("Lap : {0} / {1}", currentTour, maxTour);
    }
}
