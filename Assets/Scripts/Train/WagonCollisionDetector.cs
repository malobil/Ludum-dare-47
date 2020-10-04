using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WagonCollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        UiManager.Instance.ShowGameOver();
    }
}
