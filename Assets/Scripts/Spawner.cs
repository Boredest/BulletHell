using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

   
{
    private float timeBetweenSpawn = 1.0f;
    private float timeSinceLastSpawn;
    private Object_Pool objectPool;
    private float xSpawn;
    private float ySpawn;


    void Start()
    {
        objectPool = FindObjectOfType<Object_Pool>();
       
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if(timeSinceLastSpawn >= timeBetweenSpawn )
        {
            xSpawn = Random.Range(-8, 8);
            ySpawn = Random.Range(12, 25);
            GameObject enemyShip = objectPool.GetEnemy();
            enemyShip.transform.position = new Vector3(xSpawn, ySpawn, 0);
            timeSinceLastSpawn = 0.0f;

        }
    }
}
