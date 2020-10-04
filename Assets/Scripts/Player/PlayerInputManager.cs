using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    private PlayerInputs m_inputs = null ;

    private void Awake()
    {
        m_inputs = new PlayerInputs();
        EnableInputs();
    }

    private void EnableInputs()
    {
        m_inputs.Enable();
    }

    private void DisableInputs()
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
