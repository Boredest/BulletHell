using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Pool : MonoBehaviour
{
   
    private int poolStartSize = 8;
    public GameObject enemyPrefab;
    public Queue<GameObject> enemyPool = new Queue<GameObject>();
    int ranX;
    int ranY;


   private void Start()
    {
        for(int i = 0; i < poolStartSize; i++)
        {
            ranX = Random.Range(-8, 8);
            ranY = Random.Range(8, 20);
            GameObject enemyShip = Instantiate(enemyPrefab);
            enemyShip.transform.position = new Vector3(ranX, ranY, 0);
            enemyPool.Enqueue(enemyShip);
            enemyPrefab.SetActive(false);
            GetEnemy();
        }
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public GameObject GetEnemy()
    {
        if (enemyPool.Count > 0)
        {
            GameObject enemyShip = enemyPool.Dequeue();
            enemyShip.SetActive(true);
            return enemyShip;
        }
        else
        {

            GameObject enemyShip = Instantiate(enemyPrefab);
            return enemyShip;
        }
    }
}
