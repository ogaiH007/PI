using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public int ScoreVal;
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            PontuationController.instancia.Score += ScoreVal;
            Destroy(gameObject);
        }
    }
}
