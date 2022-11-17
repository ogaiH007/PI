using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Life : MonoBehaviour
{ 
    public int Player_life; //vida do jogador

    public GameObject heath1; //objeto do coração 1
    public GameObject heath2; //objeto do coração 2
    public GameObject heath3; //objeto do coração 3
    public GameObject GameOverTitle; //tela de morte
    public GameObject PlayerObject; //ojeto do jogador

    void Start()
    {
        Player_life = PlayerPrefs.GetInt("PlayerLife");    
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("PlayerLife", Player_life);
        }
        PlayerPrefs.SetInt("PlayerLife", Player_life);
        UpdateLifeIcon();
    }

    void UpdateLifeIcon()
    {

        if(Player_life > 3)
        {
            Player_life = 3;
        }

        switch(Player_life)
        {
            case 0:
                
                heath1.SetActive(false);
                heath2.SetActive(false);
                heath3.SetActive(false);
                GameOverTitle.SetActive(true);
                PlayerObject.SetActive(false);
                
                break;
            
            case 1:

                heath1.SetActive(true);
                heath2.SetActive(false);
                heath3.SetActive(false);

                break;
            
            case 2:

                heath1.SetActive(true);
                heath2.SetActive(true);
                heath3.SetActive(false);

                break;
            
            case 3:

                heath1.SetActive(true);
                heath2.SetActive(true);
                heath3.SetActive(true);

                break;
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        switch(collider.gameObject.tag)
        {
            case "Extra_Life":

                Player_life += 1;

                break;

            case "Enimy":

                Player_life -= 1;

                break;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Extra_Life":

                Player_life += 1;

                break;

            case "Enimy":

                Player_life -= 1;

                break;
        }
    }

    public void SetLife(int newlife)
    {
        Player_life = newlife;
        PlayerPrefs.SetInt("PlayerLife", Player_life);
    }
}
