using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    public static PlayerInputManager Instance { get; private set; }
    private PlayerInputs m_inputs = null ;

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
            
        m_inputs = new PlayerInputs();
        EnableInputs();
    }

    public void EnableInputs()
    {
        m_inputs.Enable();
    }

    public void DisableInputs()
    {
        m_inputs.Disable();
    }

    public PlayerInputs GetPlayerInput()
    {
        return m_inputs;
    }

    private void OnDisable()
    {
        m_inputs.Dispose();
    }
}
