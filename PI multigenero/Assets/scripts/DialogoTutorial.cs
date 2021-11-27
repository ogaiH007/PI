using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTutorial : MonoBehaviour
{
    public Sprite perfil;
    public string falas;
    public string nome;

    private DialogoControler DC;

    void void Start() 
    {
        DC = FindObjectOfType<DialogoControler>();
    }

    public void mostrartut()
    {
        
    }
}
