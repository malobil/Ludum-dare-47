using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalagmite : InteractableObject
{
    private void Start()
    {
        m_currentLife = m_shotToDestroy;
    }

    public override void Interact()
    {
        base.Interact();
    }
}
