﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Pool : MonoBehaviour
{
   
    public int poolStartSize = 8;
    
    public GameObject enemyPrefab;
    public Queue<GameObject> enemyPool = new Queue<GameObject>();
   

    private void Start()
    {

        for (int i = 0; i < poolStartSize; i++)
        {

            GameObject enemyShip = Instantiate(enemyPrefab);
            enemyPool.Enqueue(enemyShip);
            enemyPrefab.SetActive(false);

        }
       

    }//Start

   
    public GameObject GetEnemy()
    {
        Debug.Log(enemyPool.Count);
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

    public void returnEnemy(GameObject enemyShip)
    {
        enemyPool.Enqueue(enemyShip);
        enemyShip.SetActive(false);

    }//return Enemy

  
}
