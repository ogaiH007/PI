using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desmonstrative_Ennymi : MonoBehaviour
{
    private Transform posPlayer;

    public float EniSpeed;

    void Start()
    {
        posPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        SeguirPlayer();
    }

    void SeguirPlayer()
    {
        if (posPlayer.gameObject != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, EniSpeed * Time.deltaTime);
        }
    }
}
