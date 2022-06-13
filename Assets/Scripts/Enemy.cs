using System.Collections;
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
    }//Awake

    private void Start()
    {
        projectileOffset = new Vector3(0, -0.75f, 0);
        randomIndex = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[randomIndex];
        InvokeRepeating(nameof(FireProjectile), bulletStart, bulletRespawn);
    }//Start

    private void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if(transform.position.y < 8.5f)
        {
            isShooting = true;
 
        }
        
    }//Update

   


    private void FireProjectile()
    {
        if (isShooting)
        {
         Instantiate(this.bulletPrefab, this.transform.position + projectileOffset, Quaternion.identity);
        }
      
        
    }//FireProjectile

    private void OnDisable()
    {
        isShooting = false;
    }//OnDisable


}
