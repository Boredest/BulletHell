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
    private Vector3 bulletSpawnOffSet;

    private bool isShooting;
    private float shootDelay = 0.25f;
   
    
    public SpriteRenderer sprRenderer;
    private float playerHalfWidth;
    public float speed = 7.0f;

    public Projectile bulletPrefab;

     
    private void Awake()
    {
        sprRenderer.GetComponent<SpriteRenderer>();
        
    }//Awake
    void Start()
    {
        position = transform.position;
       
       
        playerHalfWidth = sprRenderer.bounds.size.y / 2;
        leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);
        topEdge = Camera.main.ViewportToWorldPoint(Vector3.up);
        bottomEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        isShooting = false;
        bulletSpawnOffSet = new Vector3(0.0f, this.transform.position.y + playerHalfWidth + 0.25f, 0.0f);

    }//Start


    private void Update()
    {
        checkInput();

    }//Update

    private void checkInput()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            position.x -= this.speed * Time.deltaTime;

        }

        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            position.x += this.speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            position.y += this.speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            position.y -= this.speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isShooting == false)
        {
            Shoot();
        }


        position.x = Mathf.Clamp(position.x, leftEdge.x + playerHalfWidth, rightEdge.x - playerHalfWidth);
        position.y = Mathf.Clamp(position.y, bottomEdge.y + playerHalfWidth, topEdge.y - playerHalfWidth);

        transform.position = position;
    }

    private void Shoot()
    {
        if (!isShooting)
        {
           Instantiate(this.bulletPrefab, this.transform.position + bulletSpawnOffSet, Quaternion.identity);
            isShooting = true;
            
        }

        if (isShooting)
        {
            StartCoroutine(ResetShot());
        }
    }//Shoot

    IEnumerator ResetShot()
    {
        yield return new WaitForSeconds(shootDelay);
        isShooting = false;
    }

  
}
