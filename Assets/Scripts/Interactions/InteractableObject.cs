using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private List<UnityEvent> m_interactEvent = new List<UnityEvent>() ;
    [SerializeField] private Animator m_animator = null;
    [SerializeField] private string m_triggerAnimationName = string.Empty;
    [SerializeField] private string m_boolAnimationName = string.Empty;
    [SerializeField] private bool m_interactOnShot = false;

    [Header("Aiguillage")]
    [SerializeField] private List<GameObject> m_aiguillages = new List<GameObject>();
    private int m_aiguillageIndex = 0;

    public virtual void Interact()
    {
        for(int i = 0; i < m_interactEvent.Count ; i++)
        {
            m_interactEvent[i]?.Invoke();
        }
        if(m_animator!= null)
        {
            if(m_triggerAnimationName!= null)
            {
                m_animator.SetTrigger(m_triggerAnimationName);
            }
            else if(m_boolAnimationName != null)
            {
                //m_animator.SetBool(m_boolAnimationName, true);
            }
        }
    }

    public void ToggleWagon()
    {
        Wagon.Instance.ToggleWagon();
    }

    public void ChangeAiguillage()
    {
        m_aiguillages[m_aiguillageIndex].SetActive(false);

        if(m_aiguillageIndex < m_aiguillages.Count - 1)
        {
            m_aiguillageIndex++;
        }
        else
        {
            m_aiguillageIndex = 0;
        }
      
        m_aiguillages[m_aiguillageIndex].SetActive(true);
        RailManager.Instance.RefreshPath();
    }

    public bool CheckOnShotInteraction()
    {
        return m_interactOnShot;
    }
}
