using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenNugget : MonoBehaviour
{
    private Rigidbody m_rbComp;

    public void Initialize(float speed, Vector3 direction, float timeToDelete)
    {
        float randomX = Random.Range(0f, 180f);
        float randomY = Random.Range(0f, 180f);
        float randomZ = Random.Range(0f, 180f);

        transform.eulerAngles = new Vector3(randomX, randomY, randomZ);

        m_rbComp = GetComponent<Rigidbody>();
        m_rbComp.AddForce(direction * speed, ForceMode.Impulse);
        Destroy(gameObject, timeToDelete);
    }

    private void OnCollisionEnter(Collision collision)
    {
        InteractableObject interactableObj = collision.transform.GetComponent<InteractableObject>();
        
        if (interactableObj != null)
        {
            if(interactableObj.CheckOnShotInteraction())
            {
                interactableObj.Interact();
                Destroy(gameObject);
            }
        }
    }
}
