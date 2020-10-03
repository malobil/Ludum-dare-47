using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(RailManager))]
public class RailManagerEditor : Editor
{
   private RailManager m_target ;

    private void OnEnable()
    {
        m_target = (RailManager)target;
    }

    public override void OnInspectorGUI()
    {
        if(GUILayout.Button("Refresh rails"))
        {
            m_target.RefreshPath();
            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_rails"));
        }

        base.OnInspectorGUI();
    }

    private void OnSceneGUI()
    {
        List<PathElement> rails = m_target.GetRail();
        
        for (int i = 0; i < rails.Count; i++)
        {
            Transform[] railPathPoint = rails[i].GetPathPoints();

            for (int y = 1; y < railPathPoint.Length; y++)
            {
                Vector3 previousPosition = railPathPoint[y - 1].position ;
                Vector3 actualPosition = railPathPoint[y].position;

                Handles.color = Color.blue;
                Handles.DrawLine(previousPosition, actualPosition);
            }
        }
    }


}
