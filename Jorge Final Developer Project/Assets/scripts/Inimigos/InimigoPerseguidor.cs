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
        SeguirPlayer();
    }

    void SeguirPlayer()
    {
        if (posPlayer.gameObject != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, EniSpeed * Time.deltaTime);
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.gameObject.tag)
        {
            case "sla":

                Debug.Log("Trst");

                break;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "sla":

                Debug.Log("Trst");

                break;
        }
    }
}
