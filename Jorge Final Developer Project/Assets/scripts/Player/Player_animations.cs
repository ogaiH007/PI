using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_animations : MonoBehaviour
{
    string estadoatual;

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
        if (Input.GetAxis("Vertical") > 0)
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

        if (Input.GetAxis("Horizontal") == 0)
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

    void WeponAnims()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            
        }
    }

    void mudaranim(string novoestado)
    {
        if (estadoatual == novoestado) return;

        anim.Play(novoestado);

        estadoatual = novoestado;
    }
}
