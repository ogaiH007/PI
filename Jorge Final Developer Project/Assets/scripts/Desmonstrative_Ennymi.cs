using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desmonstrative_Ennymi : MonoBehaviour
{
    private Transform posPlayer;

    public LayerMask playerLayer;
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
        Collider2D MuitoPerto = Physics2D.OverlapCircle(transform.position, 3, playerLayer);

        if (MuitoPerto != null)
        {
            Debug.Log(MuitoPerto);
            transform.position = Vector2.MoveTowards(transform.position, posPlayer.position, EniSpeed * Time.deltaTime);
        }
    }
}
