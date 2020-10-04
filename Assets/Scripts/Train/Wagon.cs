using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wagon : MonoBehaviour
{
    public static Wagon Instance { get; private set; }

    [SerializeField] private float m_speed = 1.2f;
    [SerializeField] private float m_distanceDectection = 0.25f;
    [SerializeField] private bool m_canMove = true;

    private Rigidbody m_rbComp;
   

    private Transform m_previousPoint;
    private Transform m_targetPoint;

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

    // Start is called before the first frame update
    void Start()
    {
        m_rbComp = GetComponent<Rigidbody>();
        m_previousPoint = RailManager.Instance.GetNextPoint() ;
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

        if (distance - 0.1f > m_distanceDectection)
        {
            transform.position = Vector3.MoveTowards(transform.position, RailManager.Instance.GetNextPoint().position, m_speed * Time.deltaTime);
        }
        else
        {
            SetNextPoint();
        }

        Vector3 directionToLook = (m_previousPoint.position - m_targetPoint.position).normalized ;

        if(directionToLook != Vector3.zero)
        {

            transform.rotation = Quaternion.LookRotation(directionToLook, transform.up) * Quaternion.Euler(0, 90f, 0) ;
            //transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, (m_speed/0.3f)  * Time.deltaTime);
        }
        
    }

    void SetNextPoint()
    {
        m_previousPoint = m_targetPoint;
        m_targetPoint = RailManager.Instance.GetNextPoint();
        RailManager.Instance.AddIndex();
    }

    public void StopWagon()
    {
        m_canMove = false;
    }

    public void StartWagon()
    {
        m_canMove = true ;
    }

    public void ToggleWagon()
    {
        m_canMove = !m_canMove;
    }


}
