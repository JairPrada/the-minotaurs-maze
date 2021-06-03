using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
  
}
