using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Pool : MonoBehaviour
{
   
    public int poolStartSize = 8;
    public GameObject[] enemyPrefabs;
    public Queue<GameObject> enemyPool = new Queue<GameObject>();
   

    private void Start()
    {
        
        for (int i = 0; i < poolStartSize-1; i++)
        {

            GameObject enemyShip = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)]);
            enemyPool.Enqueue(enemyShip);
            enemyShip.SetActive(false);

        }
       

    }//Start

   
    public GameObject GetEnemy()
    {
       // Debug.Log(enemyPool.Count);
        if (enemyPool.Count <= poolStartSize)
        {
            GameObject enemyShip = enemyPool.Dequeue();
            enemyShip.SetActive(true);
            return enemyShip;
        }

        else
        {
            GameObject enemyShip = null;
            return enemyShip;
        }
       
    }//GetEnemy

    public void ReturnEnemy(GameObject enemyShip)
    {
        enemyPool.Enqueue(enemyShip);
        enemyShip.SetActive(false);

    }//ReturnEnemy

  
}
