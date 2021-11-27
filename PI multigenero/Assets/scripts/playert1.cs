using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playert1 : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rig;
    
    // Start is called before the first frame update
    void Start()
    {
      rig = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        movelr();
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
}
