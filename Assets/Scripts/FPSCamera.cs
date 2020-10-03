using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    [SerializeField] private Transform m_camera = null ;
    [SerializeField] private Transform m_body = null ;

    [SerializeField] private float m_horizontalSensibility = 1f ;
    [SerializeField] private float m_verticalSensibility = 1f ;

    private float xRotation = 0f;

    private PlayerInputs m_playerInput;

    private void Start()
    {
        m_playerInput = GetComponent<PlayerInputManager>().GetPlayerInput();
    }

    private void Update()
    {
        UpdateCamera();
    }

    private void UpdateCamera()
    {
        float mouseX = m_playerInput.ClassicPlayer.MouseDelta.ReadValue<Vector2>().x * m_horizontalSensibility;
        float mouseY = m_playerInput.ClassicPlayer.MouseDelta.ReadValue<Vector2>().y * m_verticalSensibility;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        m_body.Rotate(Vector3.up * mouseX);
        m_camera.localRotation = Quaternion.Euler(xRotation,0f,0f);
    }
}
