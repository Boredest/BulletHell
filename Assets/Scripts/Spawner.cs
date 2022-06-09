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
            
            xSpawn = Random.Range(-8, 8);
            ySpawn = Random.Range(12, 25);
            if(objectPool.enemyPool.Count != 0)
           {
                
                GameObject enemyShip = objectPool.GetEnemy();
                enemyShip.transform.position = new Vector3(xSpawn, ySpawn, 0);
                Debug.Log(enemyShip);
           }
  
            timeSinceLastSpawn = 0.0f;

        }



    }
}
