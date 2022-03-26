using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenusControllers : MonoBehaviour
{
    public static MenusControllers instancia;
    public GameObject Menu;
    bool MenuAberto;
    
    void Start()
    {
        instancia = this;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!MenuAberto)
            {
                AbrirMenu();
            }
            else
            {
                FecharMenu();
            }
        }
    }

    public void AbrirMenu()
    {
        Menu.SetActive(true);
        MenuAberto = true;
    }

    public void FecharMenu()
    {
        Menu.SetActive(false);
        MenuAberto = false;
    }
}