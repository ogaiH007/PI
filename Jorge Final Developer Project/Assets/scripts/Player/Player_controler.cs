using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controler : MonoBehaviour
{
    public int idlepos;
    public float speed;
    public float SwTime;
    public GameObject Sword;
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
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movimento * Time.deltaTime * speed;
        anim.SetInteger("idle", idlepos);
        
        if(Input.GetAxis("Vertical") > 0)
        {
            idlepos = 2;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(Input.GetAxis("Vertical") < 0)
        {
            idlepos = 1;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 180f);
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            idlepos = 3;
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
            Sword.transform.eulerAngles = new Vector3(0f, 0f, -90f);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            idlepos = 3;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            Sword.transform.eulerAngles = new Vector3(0f, 0f, 90f);
        }
    }
   void Wepon()
    {
        if(Input.GetButtonDown("Fire1") && !activetimer)
        {
            Sword.SetActive(true);
            activetimer = true;
            anim.SetBool("Sword_donw", true);
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
                activetimer = false;
            }
        }
    }
}