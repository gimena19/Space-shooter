using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtaclesPool : MonoBehaviour
{
    public GameObject PrefabAbsteroide;
    private float randomX = -23f;
    private float randomY;
    [SerializeField] private float spawntime = 2.5f;
    private float timeElapsed;

    void Start()
    {

        
        
    }
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawntime)
        {
            CrearAsteroide();
        }
    }

    public void CrearAsteroide()
    {
        timeElapsed = 0f;

        for (int i=0; i<1; i++)
        {
            
            randomY = Random.Range(3.5f, -7.79f);
            GameObject a = Instantiate(PrefabAbsteroide) as GameObject;
            a.transform.position = new Vector3(randomX, randomY, 0f);
        }
    }
}
