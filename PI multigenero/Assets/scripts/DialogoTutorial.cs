using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTutorial : MonoBehaviour
{
    public Sprite perfil;
    public string[] falas;
    public string nome;

    public LayerMask playerlayer;
    public float radios;

    public float movet;
    private float timer;

    private DialogoControler DC;

    bool onradios;

    void Start() 
    {
        DC = FindObjectOfType<DialogoControler>();
    }

    public void mostrartut()
    {
        Collider2D perto = Physics2D.OverlapCircle(transform.position, radios, playerlayer);
        
        if(perto != null)
        {
            onradios = true;
        }
        else
        {
            onradios = false;
        }
    }

    void Update() 
    {
        timer += Time.deltaTime;
        
        if(timer >= movet)
        {
            timer = 0f;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(onradios)
            {
                DC.fala(perfil, falas, nome);
            }
        }
    }

    void FixedUpdate() 
    {
        mostrartut();    
    }

    private void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(transform.position, radios);
    }
}