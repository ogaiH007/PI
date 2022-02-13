using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_controler : MonoBehaviour
{
    public float speed;
    public float SwTime;
    public GameObject Sword;
    private bool activetimer;
    private float timerSw;

    void Start()
    {

    }
    void Update()
    {
        Move();  
        Wepon();
        TimerControler();
    }
    void Move()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movimento * Time.deltaTime * speed;
    }
   void Wepon()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Sword.SetActive(true);
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
                Sword.SetActive(false);
                timerSw = 0f;
            }
        }
    }
}