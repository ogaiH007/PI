using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoPerseguidor : MonoBehaviour
{
    private Transform posPlayer;

    public float EniSpeed;

    void Start()
    {
        posPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        seguirPlayer();
    }

    void seguirPlayer()
    {
        if (posPlayer.gameObject != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, EniSpeed * Time.deltaTime);
        }
    }
}
