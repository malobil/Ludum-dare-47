using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RailManager : MonoBehaviour
{
    public static RailManager Instance { get ; private set; }
    [SerializeField] private List<PathElement> m_rails = new List<PathElement>() ;
    [SerializeField] private bool m_inversePath = false;


    private int m_currentPathElementIdx = 0;
    private int m_currentPointIdx = 0 ;

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
        if(transform.childCount <= 0)
        {
            Debug.LogError("C VIDE CONNARD");
            return;
        }

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
            m_rails[i].SetNextPathElement(m_inversePath);
        }

        m_rails[0].SetPathID(0);

        m_rails.RemoveAll(x => x.GetPathID() == -1);

        m_rails.Sort((a, b) => (a.GetPathID()).CompareTo(b.GetPathID()));

        Debug.Log(CheckLoop());
    }

    public List<PathElement> GetRail()
    {
        return m_rails;
    }

    public Transform GetNextPoint()
    {
        return m_rails[m_currentPathElementIdx].GetPathPoints()[m_currentPointIdx].transform ;
    }

    public void AddIndex()
    {
        if (m_currentPointIdx < m_rails[m_currentPathElementIdx].GetPathPoints().Length - 1)
        {
            m_currentPointIdx++;
        }
        else
        {

            if(m_rails[m_currentPathElementIdx].GetNextPoint() == null)
            {
                return;
            }

            if (m_currentPathElementIdx < m_rails.Count - 1)
            {
                m_currentPathElementIdx++;
            }
            else
            {
                m_currentPathElementIdx = 0;
                GameManager.Instance.AddLap();
            }

            m_currentPointIdx = 0;
        }
      
    }

    Transform GetFirstPoint()
    {
        return m_rails[0].transform;
    }

    public void InversePath()
    {
        m_inversePath = !m_inversePath;
        SetPath();
    }

    public bool CheckLoop()
    {
        if (m_rails[m_rails.Count - 1].GetNextPoint() != null)
        {
            return true;
        }

        return false;
    }
}
