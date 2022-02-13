using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dummy_controler : MonoBehaviour
{
    public static Dummy_controler DumCon;
    public float totalDam;
    public GameObject DamTXT;
    public Text DameTXT;
    public bool activetimer;
    private float timer;
    public float Timetxt;
    void Start()
    {
        DumCon = this;
    }
    void Update()
    {
        TimerControler();
        DameTXT.text = totalDam.ToString();
    }
    void TimerControler()
    {
        if(activetimer)
        {
            timer += Time.deltaTime;

            if(timer >= Timetxt)
            {
                timer = 0f;
                DamTXT.SetActive(false);
            }
        }
    }
}