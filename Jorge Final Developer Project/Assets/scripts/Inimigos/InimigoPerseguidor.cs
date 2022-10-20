using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoPerseguidor : MonoBehaviour
{
    private Transform posPlayer;
    public LayerMask playerLayer;

    public float EniSpeed;
    public float radious;

    public int vida_inimigo;

    private bool Avistou;

    void Start()
    {
        posPlayer = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update()
    {
        SeguirPlayer();
        Debug.Log(posPlayer);
        Debug.Log(Time.deltaTime);
        Debug.Log(Time.captureFramerate);
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
        Collider2D MuitoPerto = Physics2D.OverlapCircle(transform.position, radious, playerLayer);

        if (MuitoPerto != null)
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

                PontuationController.instancia.Score += 1;
                Debug.Log("Inimigo: Levei Dano!");
                Destroy(gameObject, 0.1f);

                break;
        }
    }
}
