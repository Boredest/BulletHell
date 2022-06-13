using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

   
{
    public Player player;
    public UI ui;
  
    
    private void Start()
    {
        
    }

  
    private void Update()
    {
     
       
    }

    private void GameOver()
    {
        Debug.Log("Game Over!");
    }//GameOver

    public void PlayerReset(Player player)
    {
        player.gameObject.SetActive(true);
    }

   

    
}
