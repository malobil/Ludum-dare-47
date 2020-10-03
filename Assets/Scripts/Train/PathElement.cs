using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public enum PathElementType { Straight, Turning}

public class PathElement : MonoBehaviour
{
    [SerializeField] private Transform[] pathPoint;
    [SerializeField] private RailDetector m_exitRailDetector ;

    [SerializeField] private PathElement m_nextPathElement;
    [SerializeField] private int m_pathID = -1;

    [SerializeField] private PathElementType m_railType = PathElementType.Straight;

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

        PrefabUtility.RecordPrefabInstancePropertyModifications(this);
    }

    public int GetPathID()
    {
        return m_pathID;
    }

    public PathElementType GetPathType()
    {
        return m_railType;
    }
}

