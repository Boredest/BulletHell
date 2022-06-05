using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20.0f;
    public Vector3 direction;
   
 
    private void Update()
    {
        
        this.transform.position += direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
   
    }




}
