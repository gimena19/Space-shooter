using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;

    private CombateJugador combateJugador;
    
    private void Start()
    {
        combateJugador = GameObject.FindGameObjectWithTag("nave").GetComponent<CombateJugador>();
        combateJugador.MuerteJugador +=ActivarMenu;
    }

    public void ActivarMenu(object sender,EventArgs e)
    {
        gameOver.SetActive(true);
    }
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
