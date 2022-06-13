using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public GameObject[] lives;
    private int playerLives = 3;
    public Player player;
    private Vector3 spawnPosition;
   
    

    private void Start()
    {
        spawnPosition = Vector3.zero;
        
        
    }//Start

    private void OnCollisionEnter2D(Collision2D coll)
    {

        coll.gameObject.SetActive(false);
        player.gameObject.SetActive(false);
        PlayerHit();
       
    }//OnCol2D

    public void PlayerHit()
    {

        playerLives--;
        Destroy(lives[playerLives]);

        if (playerLives != 0)
        {
            ResetPos();
        }
        else
        {
            Debug.Log("Game Over");
        }
        
    }//PlayerHit

    public void ResetPos()
    {
        
        player.gameObject.SetActive(true);
        player.position = spawnPosition;
        
    }//Respawn

}//PlayerDamage