using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_animations : MonoBehaviour
{
    string estadoatual;

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
        //WeponAnims();
    }

    void MoveAnims()
    {
        //anim.SetInteger("idle_walk", idlepos);
        
        if(Input.GetAxis("Vertical") > 0)
        {
            mudaranim("Walk_Up");
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(Input.GetAxis("Vertical") < 0)
        {
            mudaranim("Walk_Donw");
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            mudaranim("Walk_side");
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
        if(Input.GetAxis("Horizontal") < 0)
        {
            mudaranim("Walk_side");
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if(Input.GetAxis("Horizontal") == 0)
        {
            if(estadoatual == "Walk_side")
            {
                mudaranim("idle_side");
            }
        }
        if(Input.GetAxis("Vertical") == 0)
        {
            if(estadoatual == "Walk_Up")
            {
                mudaranim("idle_up");
            }
            else if(estadoatual == "Walk_Donw")
            {
                mudaranim("idle_donw");
            }
        }
    }

    /*void WeponAnims()
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
    }*/

    void mudaranim(string novoestado)
    {
        if (estadoatual == novoestado) return;

        anim.Play(novoestado);

        estadoatual = novoestado;
    }
}
