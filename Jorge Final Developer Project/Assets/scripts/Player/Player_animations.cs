using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_animations : MonoBehaviour
{
    string estadoatual;
    public string ultimoestado;
    public static bool usingsword;

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
        WeponAnims();
    }

    void MoveAnims()
    {
        if(!usingsword)
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
            if(estadoatual == "Walk_side" || ultimoestado == "Side")
            {
                mudaranim("idle_side");
                ultimoestado = "null";
            }
        }
            if(Input.GetAxis("Vertical") == 0)
            {
                if(estadoatual == "Walk_Up" || ultimoestado == "Up")
                {
                    mudaranim("idle_up");
                    ultimoestado = "null";
                }
                else if(estadoatual == "Walk_Donw" || ultimoestado == "Donw")
                {
                    mudaranim("idle_donw");
                    ultimoestado = "null";
                }
            }
        }
    }

    void WeponAnims()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            usingsword = true;
            if (estadoatual == "Walk_Up" || estadoatual == "idle_up")
            {
                mudaranim("LinkSword_up");
                ultimoestado = "Up";
            }
            else if (estadoatual == "Walk_Donw" || estadoatual == "idle_donw")
            {
                mudaranim("LinkSword_donw");
                ultimoestado = "Donw";
            }
            else if (estadoatual == "Walk_side" || estadoatual == "idle_side")
            {
                mudaranim("LinkSword_side");
                ultimoestado = "Side";
            }
        }
    }

    void mudaranim(string novoestado)
    {
        if (estadoatual == novoestado) return;

        anim.Play(novoestado);

        estadoatual = novoestado;
    }
}
