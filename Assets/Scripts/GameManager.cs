using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private int lapToDo = 3;
    private int currentLap = 0;

    private string m_currentLoadLevel;

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
    }

    private void Start()
    {
        if (UiManager.Instance != null)
        {
            UiManager.Instance.UpdateTourCounter(currentLap, lapToDo);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevel(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
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
            LoadLevel(m_currentLoadLevel);
        }
        else
        {
            RestartGame();
        }
    }

    public void RestartGame()
    {
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

    public int GetCurrentLap()
    {
        return currentLap;
    }

    public int GetMaxLap()
    {
        return lapToDo;
    }

    public void AddLap()
    {
        currentLap++;
        UiManager.Instance.UpdateTourCounter(currentLap, lapToDo);
        if (currentLap >= lapToDo)
        {
            UiManager.Instance.ShowGameOver();
        }
    }
}
