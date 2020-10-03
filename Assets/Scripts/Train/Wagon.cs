using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wagon : MonoBehaviour
{
    [SerializeField] private float m_speed = 1.2f;
    [SerializeField] private float m_distanceDectection = 0.25f;
    private Rigidbody m_rbComp;
    private bool m_canMove = true;

    private Transform m_targetPoint;

    // Start is called before the first frame update
    void Start()
    {
        m_rbComp = GetComponent<Rigidbody>();
        transform.position = RailManager.Instance.GetNextPoint().position;
        SetNextPoint();
    }

    private void FixedUpdate()
    {
        MoveToPoint();
    }

    void MoveToPoint()
    {
        if(!m_canMove)
        {
            return;
        }

        float distance = Vector3.Distance(transform.position, m_targetPoint.position);

        if (distance > m_distanceDectection)
        {
            transform.position = Vector3.MoveTowards(transform.position, RailManager.Instance.GetNextPoint().position, m_speed * Time.deltaTime);
        }
        else
        {
            SetNextPoint();
        }
    }

    void SetNextPoint()
    {
        m_targetPoint = RailManager.Instance.GetNextPoint();
        RailManager.Instance.AddIndex();
    }

    void StopWagon()
    {
        m_canMove = false;
    }

    void StartWagon()
    {
        m_canMove = true ;
    }
}
