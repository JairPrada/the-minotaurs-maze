using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{

    public Text textContador;
    public int Cantidad = 0;

    void Update()
    {
        textContador.text = "LLAVES: " + Cantidad;
        if (Cantidad == 7)
        {
            SceneManager.LoadScene("Gano");
        }
    }
}
