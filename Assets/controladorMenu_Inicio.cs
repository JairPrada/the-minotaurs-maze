using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controladorMenu_Inicio : MonoBehaviour
{
    bool ispaused = false;
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

    public void Facil()
    {
        SceneManager.LoadScene("Facil");
    }
    public void Media()
    {
        SceneManager.LoadScene("Media");
    }
    public void Dificil()
    {
        SceneManager.LoadScene("Dificil");
    }
    public void Imposible()
    {
        SceneManager.LoadScene("Imposible");
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
    public void pause_Game()
    {
        if ( ispaused)
        {
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Play();
            }
            Time.timeScale = 1;
            ispaused = false;
        }
        else
        {
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Pause();
            }
            Time.timeScale = 0;
            
            ispaused = true;
        }
    }

    public void salir()
    {
        Application.Quit();
    }

    
    
}
