using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] private GameObject m_goldenNugget = null ;
    [SerializeField] private float m_nuggetSpeed = 5f;
    [SerializeField] private float m_nuggetCooldDown = 2f;
    [SerializeField] private float m_nuggetLifeTime = 5f;

    private float m_currentCooldown = 0f;

    private bool m_canShot = true;

    [SerializeField] private Transform m_playerCamera = null ;
    [SerializeField] private Transform m_shotPoint = null ;

    private PlayerInputs m_playerInput;

    private void Start()
    {
        m_playerInput = GetComponent<PlayerInputManager>().GetPlayerInput() ;
        m_playerInput.ClassicPlayer.Shot.performed += ctx => Shot() ;
    }

    private void Update()
    {
        if(m_currentCooldown > 0)
        {
            m_currentCooldown -= Time.deltaTime;
        }
        else
        {
            m_canShot = true;
        }
    }



    public void Shot()
    {
        if(!m_canShot)
        {
            return;
        }

        GameObject instantiateNugget = Instantiate(m_goldenNugget, m_shotPoint.position, Quaternion.identity);
        instantiateNugget.GetComponent<GoldenNugget>().Initialize(m_nuggetSpeed, m_playerCamera.forward, m_nuggetLifeTime);
        m_canShot = false;
        m_currentCooldown = m_nuggetCooldDown;
    }
}
