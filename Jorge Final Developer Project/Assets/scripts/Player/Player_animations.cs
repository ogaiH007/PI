using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_animations : MonoBehaviour
{
    public int idlepos;
    private Animator anim;

    public Player_animations instance;
    void Start()
    {
        anim = GetComponent<Animator>();
        instance = this;
    }
    void Update()
    {
        MoveAnims();
    }

    void MoveAnims()
    {
        anim.SetInteger("idle_walk", idlepos);

        if(Input.GetAxis("Vertical") > 0)
        {
            idlepos = 5;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(Input.GetAxis("Vertical") < 0)
        {
            idlepos = 4;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            idlepos = 6;
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            idlepos = 6;
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
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

    void WeponAnims()
    {
        if(Input.GetButtonDown("Fire1"))
        {
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
}
