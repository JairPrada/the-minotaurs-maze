using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Contador : MonoBehaviour
{

    public Text textContador;
    public Text textFaltantes;
    public int Cantidad = 0;
    public int NumLlaves;
    public GameObject[] Llaves;

    void Update()
    {

        Llaves = GameObject.FindGameObjectsWithTag("Coin");
        NumLlaves = Llaves.Length;
        textContador.text = "LLAVES ENCONTRADAS: " + Cantidad;
        textFaltantes.text = "FALTAN: " + NumLlaves;
        if (NumLlaves==0)
        {
            SceneManager.LoadScene("Gano");
        }
    }
}
