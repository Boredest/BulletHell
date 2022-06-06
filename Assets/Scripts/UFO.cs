using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    private float rotationSpeed = 80.0f;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;
    public float speed;
    private int randomIndex;
    private Vector2 playerPos;
    private float step;
    private Player player;
    private void Awake()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
       player = FindObjectOfType<Player>();

    }//Awake

    private void Start()
    {
        randomIndex = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[randomIndex];
    }//Start


    void Update()
    {
        if (player != null)
        {
          playerPos = new Vector2(player.transform.position.x, player.transform.position.y);
        }
        else
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
      
        step = speed * Time.deltaTime;
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        FindPlayer();
    }//Update

    private void FindPlayer()
    {
          transform.position = Vector2.MoveTowards(transform.position, playerPos, step);
    
        
    }
}
