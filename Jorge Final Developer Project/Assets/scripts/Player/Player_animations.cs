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
        usingsword = false;
        ultimoestado = PlayerPrefs.GetString("Visao");
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
            if (Input.GetAxis("Vertical") > 0 && Input.GetAxis("Horizontal") == 0)
            {
                mudaranim("Walk_Up");
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
                ultimoestado = "Up";
            }//andar apenas para cima
            if (Input.GetAxis("Vertical") < 0 && Input.GetAxis("Horizontal") == 0)
            {
                mudaranim("Walk_Donw");
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
                ultimoestado = "Donw";
            }//andar apenas para baixo

            if (Input.GetAxis("Horizontal") > 0 && Input.GetAxis("Vertical") == 0)
            {
                mudaranim("Walk_side");
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
                ultimoestado = "SideR";
            }//andar apenas para direita
            if (Input.GetAxis("Horizontal") < 0 && Input.GetAxis("Vertical") == 0)
            {
                mudaranim("Walk_side");
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
                ultimoestado = "SideL";
            }//andar apenas para equerda

            if (Input.GetAxis("Horizontal") == 0)
            {
                if (ultimoestado == "SideR")
                {
                    mudaranim("idle_side");
                    transform.eulerAngles = new Vector3(0f, 180f, 0f);
                    PlayerPrefs.SetString("Visao", "SideR");
                    ultimoestado = "Null";
                }//parado para Direita
                if (ultimoestado == "SideL")
                {
                    mudaranim("idle_side");
                    transform.eulerAngles = new Vector3(0f, 0f, 0f);
                    PlayerPrefs.SetString("Visao", "SideL");
                    ultimoestado = "Null";
                }//parado para Esquerda
            }//parado para Direita ou Esquerda
            if (Input.GetAxis("Vertical") == 0)
            {
                if (ultimoestado == "Up")
                {
                    mudaranim("idle_up");
                    PlayerPrefs.SetString("Visao", "Up");
                    ultimoestado = "Null";
                }//parado para cima
                else if(ultimoestado == "Donw")
                {
                    mudaranim("idle_donw");
                    PlayerPrefs.SetString("Visao", "Donw");
                    ultimoestado = "Null";
                }//parado para baixo
            }//parado para cima ou baixo
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
            }
            if (estadoatual == "Walk_Donw" || estadoatual == "idle_donw")
            {
                mudaranim("LinkSword_donw");
            }
            if (estadoatual == "Walk_side" || estadoatual == "idle_side")
            {
                mudaranim("LinkSword_side");
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
