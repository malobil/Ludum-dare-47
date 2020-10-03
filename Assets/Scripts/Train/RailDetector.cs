using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailDetector : MonoBehaviour
{
    [SerializeField] private LayerMask m_detectorLayer;
    [SerializeField] private bool m_isEntryPoint = false ;
    [SerializeField] private bool m_noGo = false ;

    private RailDetector m_detectedRail = null;

    public PathElement CheckNearestPath()
    {
       Collider[] detectedColliders = Physics.OverlapSphere(transform.position, 0.1f, m_detectorLayer);

        if(detectedColliders.Length > 0)
        {
            for(int i = 0; i < detectedColliders.Length; i++)
            {
                m_detectedRail = detectedColliders[i].GetComponent<RailDetector>();

                if (m_detectedRail.CheckEntryPoint() && !m_detectedRail.GetNoGo())
                {
                    return m_detectedRail.GetParentPathElement();
                }
            }
        }

        return null;
    }

    public bool CheckEntryPoint()
    {
        return m_isEntryPoint;
    }

    public PathElement GetParentPathElement()
    {
        return GetComponentInParent<PathElement>();
    }

    public bool GetNoGo()
    {
        return m_noGo;
    }
}
