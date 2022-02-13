using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_controler : MonoBehaviour
{
    public float dano_causado;     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Enimy")
        {

        }
    }
}
