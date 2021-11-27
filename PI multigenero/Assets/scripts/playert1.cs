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
        
    }

    void movelr()
    {
        if(Input.GetKey("D"))
        {
            
        }
        if(Input.GetKey(KeyCode.A))
        {
            
        }
    }
}
