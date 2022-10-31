using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oleadas : MonoBehaviour
{
    public GameObject[] SpawnPoints;
    public GameObject[] enemies;
    public int waveCount;
    public int wave;
    public int enemyType;
    public bool spawning;
    private int enemiesSpawned = 0;
   // private GameManager gameManager;



    void Start()
    {
        waveCount = 2;
        wave = 1;
        spawning = false;
        enemiesSpawned = 0;
       // gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       // if(spawing == false && enemiesSpawned ==gameManager.defeat)
    }
}
