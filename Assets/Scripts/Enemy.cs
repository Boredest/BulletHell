﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    private int randomIndex;
    public float speed = 3.0f;
    public Projectile bulletPrefab;
    private Vector3 projectileOffset;
    private float bulletRespawn = 1.5f;
    private float bulletStart = 4.0f;
    private bool isShooting = false;
    




    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        projectileOffset = new Vector3(0, -0.65f, 0);
        randomIndex = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[randomIndex];
        InvokeRepeating(nameof(FireProjectile), bulletStart, bulletRespawn);
    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if(transform.position.y < 7.0f)
        {
            isShooting = true;
 
        }
        
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            Destroy(coll.gameObject);
            this.gameObject.SetActive(false);
            //to do particle effect and score?
        }
        else
        {
            this.gameObject.SetActive(false);
        }
        

    }


    private void FireProjectile()
    {
        if (isShooting)
        {
         Instantiate(this.bulletPrefab, this.transform.position + projectileOffset, Quaternion.identity);
        }
      
        
    }


    //todo
    //hp?
}
