using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controler : MonoBehaviour
{
    public float speed;
    public float SwTime;
    public GameObject Sword;
    
    private bool usingwepon;
    private bool activetimer;
    private float timerSw;

    private Animator anim;
    public Player_controler instance;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        instance = this;
    }
    void Update()
    {
        Move();  
        Wepon();
        TimerControler();
        //Sword.transform.position = new Vector3(0f, 0f, 0f);
    }
    void Move()
    {
        if(!usingwepon)
        {
            Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
            transform.position += movimento * Time.deltaTime * speed;
        }

        if(Input.GetAxis("Vertical") > 0)
        {
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(Input.GetAxis("Vertical") < 0)
        {
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 180f);
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            Sword.transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
    }
   void Wepon()
    {
        if(Input.GetButtonDown("Fire1") && !activetimer)
        {
            usingwepon = true;
            activetimer = true;
        }
    }
    void TimerControler()
    {
        if(activetimer)
        {
            timerSw += Time.deltaTime;

            if(timerSw >= SwTime)
            {
                anim.SetBool("Sword_donw", false);
                anim.SetBool("Sword_up", false);
                anim.SetBool("Sword_side", false);
                timerSw = 0f;
                Sword.SetActive(false);
                activetimer = false;
                usingwepon = false;
            }
        }
    }
}