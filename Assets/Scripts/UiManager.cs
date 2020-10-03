using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager Instance { get; private set; }
    [SerializeField] GameObject m_pauseMenu;

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

    public bool PauseMenuState()
    {
        return m_pauseMenu.active;
    }
}
