using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathElement : MonoBehaviour
{
    [SerializeField] private Transform[] pathPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform[] GetPathPoints()
    {
        return pathPoint;
    }
}

