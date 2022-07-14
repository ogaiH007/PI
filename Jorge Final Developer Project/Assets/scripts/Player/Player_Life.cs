using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Life : MonoBehaviour
{
    public int Player_life;

    public GameObject heath1;
    public GameObject heath2;
    public GameObject heath3;
    public GameObject GameOverTitle;
    public GameObject PlayerObject;

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
        if(Player_life == 3)
        {
            heath1.SetActive(true);
            heath2.SetActive(true);
            heath3.SetActive(true);
        }
        if (Player_life == 2)
        {
            heath1.SetActive(true);
            heath2.SetActive(true);
            heath3.SetActive(false);
        }
        if (Player_life == 1)
        {
            heath1.SetActive(true);
            heath2.SetActive(false);
            heath3.SetActive(false);
        }
        if (Player_life == 0)
        {
            heath1.SetActive(false);
            heath2.SetActive(false);
            heath3.SetActive(false);
            GameOverTitle.SetActive(true);
            PlayerObject.SetActive(false);
        }
        if(Player_life > 3)
        {
            Player_life = 3;
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Extra_Life")
        {
            Player_life += 1;
        }
        if (collider.gameObject.tag == "Enimy")
        {
            Player_life -= 1;
        }
    }

    public void SetLife(int newlife)
    {
        Player_life = newlife;
        PlayerPrefs.SetInt("PlayerLife", Player_life);
    }
}
