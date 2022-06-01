using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20.0f;
    public Vector3 direction;

    void Update()
    {
        this.transform.position += Vector3.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(this.gameObject);
     
    }
}
