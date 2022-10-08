using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controler : MonoBehaviour
{
    public float speed;
    public GameObject Sword;
    
    private bool usingwepon;
        
    void Update()
    {
        Move();  
        Wepon();
    }
    void Move()
    {
        if(!usingwepon)
        {
            Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
            transform.position += movimento * Time.deltaTime * speed;
        }

        if(Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") == 0)
        {
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") == 0)
        {
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 180f);
        }
        if(Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") == 0)
        {
            Sword.transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }
        if(Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") == 0)
        {
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
    }
    void Wepon()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if( !usingwepon)
            {
                StartCoroutine("WeponButon");
            }
        }
    }
    IEnumerator WeponButon()
    {
        Sword.SetActive(true);
        usingwepon = true;
        yield return new WaitForSeconds(0.45f);
        Sword.SetActive(false);
        usingwepon = false;
        Player_animations.usingsword = false;
    }
}