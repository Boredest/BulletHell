using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20.0f;
    public Vector3 direction;
    private float lifeTime = 7.0f;
   
 
    private void Update()
    {
        
        this.transform.position += direction * speed * Time.deltaTime;
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {

            coll.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }

        else if (coll.gameObject.CompareTag("Player"))
        {
            Destroy(coll.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }
   
    }




}
