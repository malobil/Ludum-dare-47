using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private string m_currentLoadLevel;
    private int m_currentLevelIdx;

    private int m_currentPoint = 0;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }

        m_currentLevelIdx = 1;
        DontDestroyOnLoad(gameObject);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad + m_currentLevelIdx);
        m_currentLoadLevel = levelToLoad + m_currentLevelIdx;
    }

    public void RestartLevel()
    {
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }

    public void ResumeGame()
    {
        UiManager.Instance.ShowPauseMenu(false);
    }

    public void NextLevel()
    {
        if(SceneManager.GetActiveScene() != SceneManager.GetSceneByName("Scene_10"))
        {
            m_currentLevelIdx++;
            LoadLevel(m_currentLoadLevel);
        }
        else
        {
            RestartGame();
        }
    }

    public void RestartGame()
    {
        m_currentLevelIdx = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void AddPoint(int pointToAdd)
    {
        m_currentPoint += pointToAdd;
        UiManager.Instance.UpdatePoints(m_currentPoint);
    }

    public int GetCurrentPoint()
    {
        return m_currentPoint;
    }
}
