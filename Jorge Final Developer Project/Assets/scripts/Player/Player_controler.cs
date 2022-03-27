using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controler : MonoBehaviour
{
    public int idlepos;
    public float speed;
    public float SwTime;
    public GameObject Sword;
    
    private bool usingwepon;
    private bool activetimer;
    private float timerSw;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
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
            anim.SetInteger("idle_walk", idlepos); 
        }
        
        if(Input.GetAxis("Vertical") > 0)
        {
            idlepos = 5;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(Input.GetAxis("Vertical") < 0)
        {
            idlepos = 4;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 180f);
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            idlepos = 6;
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
            Sword.transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            idlepos = 6;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }

        if(Input.GetAxis("Horizontal") == 0)
        {
            if(idlepos == 6)
            {
                idlepos = 3;
            }
        }
        if(Input.GetAxis("Vertical") == 0)
        {
            if(idlepos == 4)
            {
                idlepos = 1;
            }
            else if(idlepos == 5)
            {
                idlepos = 2;
            }
        }
    }
   void Wepon()
    {
        if(Input.GetButtonDown("Fire1") && !activetimer)
        {
            usingwepon = true;
            Sword.SetActive(true);
            activetimer = true;
            //anim.SetBool("Sword_donw", true);
            if(Input.GetAxis("Vertical") < 0)
            {
                anim.SetBool("Sword_donw", true);
            }
            if(Input.GetAxis("Vertical") > 0)
            {
                anim.SetBool("Sword_up", true);
            }
            if(Input.GetAxis("Horizontal") > 0)
            {
                anim.SetBool("Sword_side", true);
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
            if(Input.GetAxis("Horizontal") < 0)
            {
                anim.SetBool("Sword_side", true);
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
            
            if(Input.GetAxis("Vertical") == 0)
            {
                if(idlepos == 1)
                {
                    anim.SetBool("Sword_donw", true);
                }
                else if(idlepos == 2)
                {
                    anim.SetBool("Sword_up", true);
                }
            }
            if(Input.GetAxis("Horizontal") == 0)
            {
                if(idlepos == 3)
                {
                    anim.SetBool("Sword_side", true);
                }
            }
        }
        
    }
    void TimerControler()
    {
        if(activetimer)
        {
            timerSw += Time.deltaTime;

            if(timerSw >= SwTime)
            {
                timerSw = 0f;
                Sword.SetActive(false);
                anim.SetBool("Sword_donw", false);
                anim.SetBool("Sword_up", false);
                anim.SetBool("Sword_side", false);
                activetimer = false;
                usingwepon = false;
            }
        }
    }
}