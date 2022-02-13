using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controler : MonoBehaviour
{
    public float speed;
    public float SwTime;

    public GameObject Sword;

    private bool activetimer;
    private float timerSw;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      Move();  
      Wepon();

      if(activetimer)
      {
          timerSw += Time.deltaTime;

          if(timerSw >= SwTime)
          {
              Sword.SetActive(false);
              timerSw = 0f;
          }
      }
    }

    void Move()
    {
        //movimento vertical
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movimento * Time.deltaTime * speed;
    }

   void Wepon()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Sword.SetActive(true);
            activetimer = true;
        }
        /*if(Input.GetButtonUp("Fire1"))
        {
            Sword.SetActive(false);
        }*/
    }
}
