using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoPerseguidor : MonoBehaviour
{
    private Transform posPlayer;
    public LayerMask playerLayer;

    public float EniSpeed;
    public float radious;

    private bool Avistou;

    void Start()
    {
        posPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        SeguirPlayer();
    }
    private void FixedUpdate()
    {
        AvistouTeste();
    }

    void SeguirPlayer()
    {
        if (posPlayer.gameObject != null && Avistou)
        {
            transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, EniSpeed * Time.deltaTime);
        }        
    }
    void AvistouTeste()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);

        if (hit != null)
        {
            Avistou = true;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radious);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.gameObject.tag)
        {
            case "Wepon":

                Debug.Log("Inimigo: Levei Dano!");
                Destroy(gameObject, 0.1f);

                break;
        }
    }
}
