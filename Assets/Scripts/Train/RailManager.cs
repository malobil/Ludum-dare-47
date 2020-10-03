using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RailManager : MonoBehaviour
{
    public static RailManager Instance { get ; private set; }
    [SerializeField] private List<PathElement> m_rails = new List<PathElement>() ;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void RefreshPath()
    {
        m_rails.Clear();
        SetPath();
    }

    public void SetPath()
    {
        foreach (Transform child in transform)
        {
            if (child.GetComponent<PathElement>())
            {
                m_rails.Add(child.GetComponent<PathElement>());
            }
        }

        for(int i = 0; i < m_rails.Count; i++)
        {
            m_rails[i].ResetPathID();
            m_rails[i].SetNextPathElement();
        }

        m_rails[0].SetPathID(0);

        m_rails.RemoveAll(x => x.GetPathID() == -1);

        m_rails.Sort((a, b) => (a.GetPathID()).CompareTo(b.GetPathID()));
        
    }

    public List<PathElement> GetRail()
    {
        return m_rails;
    }
}
