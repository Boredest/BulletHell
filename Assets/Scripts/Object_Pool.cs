using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Pool : MonoBehaviour
{
   
    private int poolStartSize = 5;
    public GameObject enemyPrefab;
    public Queue<GameObject> enemyPool = new Queue<GameObject>();


   private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
