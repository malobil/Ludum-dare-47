using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour, InteractableElement
{
    [SerializeField] private List<UnityEvent> m_interactEvent = new List<UnityEvent>() ;
    public virtual void Interact()
    {
        for(int i = 0; i < m_interactEvent.Count ; i++)
        {
            m_interactEvent[i]?.Invoke();
        }
    }

    public void ToggleWagon()
    {
        Wagon.Instance.ToggleWagon();
    }
}
