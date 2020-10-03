using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailManager : MonoBehaviour
{
    private List<PathElement> m_rails = new List<PathElement>();

    // Start is called before the first frame update
    void Start()
    {
        GetAllRails();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetAllRails()
    {
        foreach(Transform child in transform)
        {
            PathElement rail = child.GetComponent<PathElement>();

            if(rail != null)
            {
                m_rails.Add(rail);
            }
        }
    }
}
