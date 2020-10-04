using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    [SerializeField] private float m_interactionDistance = 5f;
    [SerializeField] private Transform m_camera = null ;

    private PlayerInputs m_playerInput;

    // Start is called before the first frame update
    void Start()
    {
        m_playerInput = GetComponent<PlayerInputManager>().GetPlayerInput() ;
        m_playerInput.ClassicPlayer.Interaction.performed += ctx => Interact();
        m_playerInput.ClassicPlayer.Pause.performed += ctx => Pause();
        m_playerInput.ClassicPlayer.RestartLevel.performed += ctx => Restart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Interact()
    {
        RaycastHit hit;

        if(Physics.Raycast(m_camera.position,m_camera.forward,out hit,m_interactionDistance))
        {
            InteractableObject touchedInteractElement = hit.transform.gameObject.GetComponent<InteractableObject>();
           
            if (touchedInteractElement != null)
            {
                touchedInteractElement.Interact();
            }
        }
    }

    private void Pause()
    {
        if (!UiManager.Instance.PauseMenuState())
        {
            UiManager.Instance.ShowPauseMenu(true);
        }
        else
            UiManager.Instance.ShowPauseMenu(false);
    }

    private void Restart()
    {
        GameManager.Instance.RestartLevel();
    }
}
