using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathElement : MonoBehaviour
{
    [SerializeField] private Transform[] pathPoint;
    [SerializeField] private RailDetector m_exitRailDetector ;

    public PathElement m_nextPathElement;
    public int m_pathID = -1;

    public Transform[] GetPathPoints()
    {
        return pathPoint;
    }

    public PathElement GetNextPoint()
    {
        return m_nextPathElement;
    }

    public void SetNextPathElement()
    {
        m_nextPathElement =  m_exitRailDetector.CheckNearestPath();
    }

    public void ResetPathID()
    {
        m_pathID = -1;
    }

    public void SetPathID(int newID)
    {
        m_pathID = newID;
        
        if(m_nextPathElement != null && m_nextPathElement.GetPathID() == -1)
        {
            int nextID = newID + 1;
            m_nextPathElement.SetPathID(nextID) ;
        }
    }

    public int GetPathID()
    {
        return m_pathID;
    }
}

