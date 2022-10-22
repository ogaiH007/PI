using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geraçãodeinimigos : MonoBehaviour
{
    Vector3 LugarDoSpawn = new Vector3(0,0,0);
    public GameObject inimigo;
    public int minimoDeInimigos = 1, maximoDeInimigos = 10;//ajuste o minimo e o maximo para o sorteio

    private float X, Y;

    public float RangeMinX, RangeMaxX, RangeMinY, RangeMaxY;
    void Start()
    {        
        int quantidade = Random.Range(minimoDeInimigos, maximoDeInimigos); // aqui acontece o sorteio da quantidade de inimigos
        for (int x = 0; x < quantidade; x++)
        {
            X = Random.Range(RangeMinX, RangeMaxX);
            Y = Random.Range(RangeMinY, RangeMaxY);
            LugarDoSpawn = new Vector3(X, Y, 0f);
            Instantiate(inimigo, LugarDoSpawn, transform.rotation); // instancia um inimigo aleatorio
        }
    }
}