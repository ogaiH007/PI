using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoControler : MonoBehaviour
{
    public GameObject dialogoobj;
    public Image imjperfil;
    public Text txtfala;
    public Text txtnome;

    public float txtspeed;

    private string[] paginas;
    private int index;

    public void fala(Sprite p, string[] fal, string nom)
    {
        dialogoobj.SetActive(true);
        imjperfil.sprite = p;
        paginas = fal;
        txtnome.text = nom;
        StartCoroutine(TypeSentence());
    }

    IEnumerator TypeSentence()
    {
        foreach (char frases in paginas[index].ToCharArray())
        {
            txtfala.text += frases;
            yield return new WaitForSeconds(txtspeed);
        }
    }

    public void proxpagina()
    {
        if(txtfala.text == paginas[index])
        {
            if(index < paginas.Length - 1)
            {
                index ++;
                txtfala.text = " ";
                StartCoroutine(TypeSentence());
            }
            else
            {
                txtfala.text = " ";
                index = 0;
                dialogoobj.SetActive(false);
            }
        }
    }
}