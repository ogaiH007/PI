using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playert1 : MonoBehaviour
{
    public float Speed;
    public float jumpForce;

    bool skiljumpv;
    bool isjumping;

    private Rigidbody2D rig;
    private ArvoreControler ac;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ac = FindObjectOfType<ArvoreControler>();
    }

    // Update is called once per frame
    void Update()
    {
        movelr();
        jump();
    }

    void movelr()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(1*Speed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-1*Speed*Time.deltaTime,0,0);
        }
    }

    void jump()
    {
        if(skiljumpv)
        {
            if(Input.GetButtonDown("Jump"))
            {
                if(!isjumping)
                {
                    rig.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D colli) 
    {
        if(colli.gameObject.layer == 6)
        {
            isjumping = false;
        }
    }

    void OnCollisionExit2D(Collision2D colli) 
    {
        if(colli.gameObject.layer == 6)
        {
            isjumping = true;
        }
    }

    public void skiljump()
    {
        skiljumpv = true;
    }
}
