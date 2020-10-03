using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableElement : MonoBehaviour
{
    public virtual void Interact()
    {
        Debug.LogFormat("Interact with me {0}", gameObject.name);
    }
}
