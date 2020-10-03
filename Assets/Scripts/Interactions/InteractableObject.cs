using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour, InteractableElement
{
    [SerializeField] private List<UnityEvent> m_interactEvent = new List<UnityEvent>() ;
    [SerializeField] private Animator m_animator = null;
    [SerializeField] private string m_triggerAnimationName = string.Empty;
    public virtual void Interact()
    {
        for(int i = 0; i < m_interactEvent.Count ; i++)
        {
            m_interactEvent[i]?.Invoke();
        }
        if(m_animator!= null)
        {
            m_animator.SetTrigger(m_triggerAnimationName);
        }
    }

    public void ToggleWagon()
    {
        Wagon.Instance.ToggleWagon();
    }
}
