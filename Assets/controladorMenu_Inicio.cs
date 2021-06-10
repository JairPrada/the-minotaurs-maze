using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controladorMenu_Inicio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiarADificultad()
    {
        SceneManager.LoadScene("Menu_Dificultad");
    }

    public void cambiarAJuego()
    {
        SceneManager.LoadScene("principal");
    }

    public void cambiarAInicio()
    {
        SceneManager.LoadScene("Menu_Inicio");
    }
    public void cambiarAOpciones()
    {
        SceneManager.LoadScene("Menu_Opciones");
    }

    public void pausa()
    {
        SceneManager.LoadScene("Menu_Pausa");
    }


    public void salir()
    {
        Application.Quit();
    }

    
    
}
