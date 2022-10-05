using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoPerseguidor : MonoBehaviour
{
    private Transform posPlayer;
    public LayerMask playerLayer;
    private Animator anim;

    public float EniSpeed;
    private bool EniActive;
    public float radious;

    void Start()
    {
        anim = GetComponent<Animator>();

        posPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        EniActive = false;
    }

    void Update()
    {
        SeguirPlayer();
    }

    private void FixedUpdate()
    {
        Avistado();
    }

    void SeguirPlayer()
    {
        if (EniActive)
        {
            if (posPlayer.gameObject != null)
            {
                transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, EniSpeed * Time.deltaTime);
            }
        }
    }

    public void Avistado()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);

        if (hit != null)
        {
            EniActive = true;
        }
        else
        {
            
        }
    }

    public void Animacao()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radious);
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
    void mudaranim(string novoestado)
    {
        anim.Play(novoestado);
    }
}
