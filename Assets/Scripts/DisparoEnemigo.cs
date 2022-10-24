using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    [SerializeField] private Transform ControladorDisparo;
    [SerializeField] private GameObject bala;
    [SerializeField] private float spawntime = 2.5f;
    private float Tiempo;


    private void Update()
    {


        Tiempo += Time.deltaTime;

            if (Tiempo > spawntime)
            {
                Disparar();
            }
            
        

        
    }

    private void Disparar()
    {
        Tiempo = 0f;
        Instantiate(bala, ControladorDisparo.position, ControladorDisparo.rotation);
    }
}
