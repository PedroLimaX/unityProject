using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarEscena( string nombreEscena){
        SceneManager.LoadScene(nombreEscena);
    }

    public void Inicio(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Salir(){
        Application.Quit();
    }
}
