using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoControler : MonoBehaviour
{
    public GameObject dialogoobj;
    public Image imjperfil;
    public Text txtfala;
    public Text txtnome;

    public float txtspeed;

    public void fala(Sprite p, string fal, string nom)
    {
        dialogoobj.SetActive(true);
        imjperfil.sprite = p;
        txtfala.text = fal;
        txtnome.text = nom;
    }
}