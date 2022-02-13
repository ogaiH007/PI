using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_controler : MonoBehaviour
{
    public float dano_causado;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Enimy")
        {
            Dummy_controler.instance.DanoRecebido = dano_causado;
            Dummy_controler.instance.damtxt.SetActive(true);
            Dummy_controler.instance.activetimer = true;
        }
    }
}
