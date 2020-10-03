using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wagon : MonoBehaviour
{
    private Rigidbody m_rbComp;

    // Start is called before the first frame update
    void Start()
    {
        m_rbComp = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPoint();
    }

    void MoveToPoint()
    {
       transform.position = Vector3.MoveTowards(transform.position, RailManager.Instance.GetNextPoint().position, 1f);
    }

}
