using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    [SerializeField] private Transform ControladorDisparo;
    [SerializeField] private GameObject bala;
    private float spawntime = 0.5f;
    private float Tiempo;


    private void Update()
    {

        spawntime = Random.Range(1.5f, 3f);
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
