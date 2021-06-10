using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ObjectInteracts : MonoBehaviour
{



    public Contador contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = GameObject.FindGameObjectWithTag("Player").GetComponent<Contador>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            contador.Cantidad = contador.Cantidad + 1;
            Destroy(gameObject);
            
        }
        
    }
}
