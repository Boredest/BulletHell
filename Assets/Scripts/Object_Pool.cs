using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Pool : MonoBehaviour
{
   
    public int poolStartSize = 10;
    public int ufoPoolSize = 3;
    public GameObject enemyPrefab;
    public GameObject ufoPrefab;
    public Queue<GameObject> enemyPool = new Queue<GameObject>();
    public Queue<GameObject> ufoPool = new Queue<GameObject>();


    private void Start()
    {
        //Fill Pool and add to queue
        for(int i = 0; i < poolStartSize; i++)
        {
            
            GameObject enemyShip = Instantiate(enemyPrefab);
            enemyPool.Enqueue(enemyShip);
            enemyPrefab.SetActive(false);
         
        }

        for (int i = 0; i < ufoPoolSize; i++)
        {

            GameObject ufo = Instantiate(ufoPrefab);
            ufoPool.Enqueue(ufo);
            ufo.SetActive(false);
           
        }

    }//Start

   
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
    }//GetEnemy

    public void returnEnemy(GameObject enemyShip)
    {
        enemyPool.Enqueue(enemyShip);
        enemyShip.SetActive(false);

    }//return Enemy

    public GameObject GetUFO()
    {
        if (ufoPool.Count > 0)
        {
            GameObject ufo = ufoPool.Dequeue();
            ufo.SetActive(true);
            return ufo;
        }

        else
        {
            GameObject ufo = Instantiate(ufoPrefab);
            return ufo;
        }
    }//GetUFO
    public void returnUFO(GameObject ufo)
    {
        enemyPool.Enqueue(ufo);
        ufo.SetActive(false);

    }//return Enemy
}
