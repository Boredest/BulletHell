using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20.0f;
    public Vector3 direction;
    private float lifeTime;

    void Update()
    {
        this.transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
        }
           
  
    }




}
