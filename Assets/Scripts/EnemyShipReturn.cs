using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipReturn : MonoBehaviour
{

    private Object_Pool objectPool;

    void Start()
    {
        objectPool = FindObjectOfType<Object_Pool>();
    }//Start

    private void OnDisable()
    {
        if (objectPool != null)
        {
            objectPool.ReturnEnemy(this.gameObject);
        }
    }//onDisable

}
