using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dummy_controler : MonoBehaviour
{
    public float timerdantxt;
    public float DanoRecebido;
    public GameObject damtxt;   
    private float timer;
    public bool activetimer;
    public Text DanoRec;
    public static Dummy_controler instance;
    void Start()
    {
        instance = this;
    }
    void Update()
    {
        TimerControler();
        DanoRec.text = DanoRecebido.ToString();
    }
    void TimerControler()
    {
        if(activetimer)
        {
            timer += Time.deltaTime;

            if(timer >= timerdantxt)
            {
                damtxt.SetActive(false);
                timer = 0f;
            }
        }
    }
}