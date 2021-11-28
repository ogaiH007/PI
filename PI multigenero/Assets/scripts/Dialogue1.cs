using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue1 : MonoBehaviour
{
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;

    public LayerMask playerLayer;
    public float radious;

    private DialogControl dc;
    bool onRadious;
    bool dialogochamado;

    private void Start() 
    {
        dc = FindObjectOfType<DialogControl>();
    }

    private void FixedUpdate() 
    {
        Interact();    
    }

    private void Update() 
    {
        if(!dialogochamado)
        {
            if(Input.GetKeyDown(KeyCode.Space) && onRadious)
                {
                    dc.Speech(profile, speechTxt, actorName);
                    dialogochamado = true;
                }
        }
        
    }

    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);

        if(hit != null)
        {
            onRadious = true;
        }
        else
        {
            onRadious = false;
        }
    }

    private void OnDrawGizmosSelected() 
    {
        Gizmos.DrawWireSphere(transform.position, radious);
    }

    public void ativatebuton()
    {
        dialogochamado = false;
    }
}
