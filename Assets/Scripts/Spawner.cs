using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

   
{
    private float timeBetweenSpawn = 1.0f;
    private float timeSinceLastSpawn;
    private float timeSinceLastUFOSpawn;
    private float timeBetweenUFOSpawn = 5.0f;
    private Object_Pool objectPool;
    private float xSpawn;
    private float ySpawn;
    private float ufoxSpawn;


    void Start()
    {
        objectPool = FindObjectOfType<Object_Pool>();
       

    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        timeSinceLastUFOSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= timeBetweenSpawn )
       {
            Debug.Log(xSpawn);
            xSpawn = Random.Range(-8, 8);
            ySpawn = Random.Range(12, 30);
            GameObject enemyShip = objectPool.GetEnemy();
            enemyShip.transform.position = new Vector3(xSpawn, ySpawn, 0);
            timeSinceLastSpawn = 0.0f;

        }

        if(timeSinceLastUFOSpawn >= timeBetweenUFOSpawn )
        {
            xSpawn = Random.Range(-15, 20);
            ySpawn = Random.Range(12, 30);
            GameObject ufo = objectPool.GetUFO();
            ufo.transform.position = new Vector3(xSpawn, ySpawn, 0);
            timeSinceLastUFOSpawn = 0.0f;

        }
    }
}
