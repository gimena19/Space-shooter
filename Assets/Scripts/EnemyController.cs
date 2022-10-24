using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField] private int poolSize = 5;
    [SerializeField] private float ySpanwPosition = 2.5f;
    [SerializeField] private GameObject Enemigo;
    [SerializeField] private float spawntime = 2.5f;
    private GameObject[] obstacles;
    private float timeElapsed;
    private int obstacleCount = 0;
    private float xPawnPosition = -29f;
    

    // Start is called before the first frame update
    void Start()
    {
        obstacles = new GameObject[poolSize];

        for (int i = 0; i < poolSize; i++)
        {
            obstacles[i] = Instantiate(Enemigo);
            obstacles[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > spawntime)
        {
            SpawnObstacle();

        }

    }

    private void SpawnObstacle()
    {
        timeElapsed = 0f;

       // = Random.Range(minYposition, maxYposition);
        Vector2 spawnPosition = new Vector2(xPawnPosition, ySpanwPosition);
        obstacles[obstacleCount].transform.position = spawnPosition;

        if (!obstacles[obstacleCount].activeSelf)
        {
            obstacles[obstacleCount].SetActive(true);
        }


        obstacleCount++;

   
    }
}
