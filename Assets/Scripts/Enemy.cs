using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int sprArrSize = 4;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    private int randomIndex;
   



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
        transform.position += Vector3.down * Time.deltaTime;
    }

    //todo
    //col
    //shooting
    //hp?
}
