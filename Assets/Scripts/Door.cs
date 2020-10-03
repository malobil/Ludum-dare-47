using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private bool m_isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(!m_isOpen && RailManager.Instance.CheckLoop())
        {
            m_isOpen = true;
            gameObject.SetActive(false);
        }
       else if(m_isOpen && !RailManager.Instance.CheckLoop())
        {
            m_isOpen = false;
            gameObject.SetActive(true);
        }
    }
}
