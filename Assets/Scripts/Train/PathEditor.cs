using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(PathElement))]
[CanEditMultipleObjects]
public class PathEditor : Editor
{
    PathElement _target ;

    private void OnEnable()
    {
        _target = (PathElement)target;    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnSceneGUI()
    {
        for (int i = 1; i < _target.GetPathPoints().Length; i++)
        {
            Vector3 previousPosition = _target.GetPathPoints()[i - 1].position;
            Vector3 actualPosition = _target.GetPathPoints()[i].position;

            Handles.color = Color.blue;
            Handles.DrawLine(previousPosition, actualPosition);
        }
    }
}
#endif