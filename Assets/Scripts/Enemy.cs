using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    private int randomIndex;
    public float speed = 3.0f;
   



    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        randomIndex = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[randomIndex];
    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player") )
        {
            Destroy(coll.gameObject);
            Destroy(this.gameObject);
            //to do particle effect and score?
        }

    }


    //todo
    //col
    //shooting
    //hp?
}
