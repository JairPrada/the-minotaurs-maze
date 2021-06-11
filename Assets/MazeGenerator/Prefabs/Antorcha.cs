using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antorcha: MonoBehaviour
{
    public float intensidad = 1.5f; //Intencidad que tiene la llama
    public float minIntenci = 0.5f; //Intencidad minima que tendra la llama
    public float maxIntenci = 1.5f; //Intencidad maxima que tendra la llama
    public float vel = 5f; //velocidad del parpadeo de la llama

    public bool fuegoCambia = false; //Controla si la llama cambia

    private void Update() //Se actualiza 1 vez por frame
    {
        CambiarIntensidad(); //Llama esta funcion
    }

    void CambiarIntensidad() //Funcion que hace que el fuego cambie
    {
        GetComponent<Light>().intensity = intensidad; //Obtiene la intencidad del fuego y hace que sea igual a la variable intencidad en todo momento

        if (intensidad <= minIntenci) //Si intencidad es menor que el minimo...
        {
            fuegoCambia = false; //fuego se hace false
        }
        else if (intensidad >= maxIntenci)//Si intencidad es mayor que el maximo
        {
            fuegoCambia = true; //fuego se hace true
        }

        //Efecto ping pong
        if (fuegoCambia == true)//si fuego es true
        {
            intensidad -= vel * Time.deltaTime; //La intencidad baja a la velocidad que le demos
        }
        else //Si el fuego es false;
        {
            intensidad += vel * Time.deltaTime; //La intencidad sube a la velocidad que le demos
        }
    }
}