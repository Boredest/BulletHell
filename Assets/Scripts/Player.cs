using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private Vector3 leftEdge;
    private Vector3 rightEdge;
    private Vector3 topEdge;
    private Vector3 bottomEdge;
    private Vector3 position;
    public SpriteRenderer sprRenderer;
    private float playerHalfWidth;
    

    public float speed = 5.5f;

     
    private void Awake()
    {
        sprRenderer.GetComponent<SpriteRenderer>();
        
    }//Awake
    void Start()
    {
        Vector3 position = transform.position;
        playerHalfWidth = sprRenderer.bounds.size.x / 2;
        leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
        topEdge = Camera.main.ViewportToWorldPoint(Vector3.up);
        bottomEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);

    }//Start


    private void Update()
    {
        position = transform.position;
        
      
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) 
        {
            position.x -=  this.speed * Time.deltaTime;
          
        }

        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            position.x +=  this.speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            position.y += this.speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= this.speed * Time.deltaTime;
        }

     
        position.x = Mathf.Clamp(position.x, leftEdge.x + playerHalfWidth, rightEdge.x - playerHalfWidth);
        position.y = Mathf.Clamp(position.y, bottomEdge.y + playerHalfWidth, topEdge.y - playerHalfWidth);

        transform.position = position;

      

    }//Update

    private void Shoot()
    {
        //todo
    }//Shoot
}
