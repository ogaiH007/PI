using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArvoreControler : MonoBehaviour
{
    private int SkilsPoints = 1;
    
    public GameObject AbrirArvB;
    public GameObject ArvoreJan;
    
    public GameObject ControleSkilPipe;
    public GameObject GraficosSkilPipe;
    public GameObject MainSkilPipe;

    public GameObject ControleSkilfalse;
    public GameObject GraficosSkilfalse;
    public GameObject MainSkilfalse;

    public GameObject ControleSkiltrue;
    public GameObject GraficosSkiltrue;
    public GameObject MainSkiltrue;

    bool skilgraficos01;
    bool skilcontroles01;
    bool skilmain01;

    public Text skilpointtxt;
    
    private playert1 player;

    // Start is called before the first frame update
    private void Start()
    {
        player = FindObjectOfType<playert1>();
    }

    // Update is called once per frame
    private void Update()
    {
        skilpointtxt.text = SkilsPoints.ToString();
    }

    void updatesp()
    {

    }
    
    public void abrirArvore()
    {
        ArvoreJan.SetActive(true);
        AbrirArvB.SetActive(false);
    }
    public void fecharArvore()
    {
        ArvoreJan.SetActive(false);
        AbrirArvB.SetActive(true);
    }

    public void ControlerSkil()
    {
        if(SkilsPoints>0 && !skilcontroles01)
        {
            SkilsPoints--;
            ControleSkilPipe.SetActive(true);
            ControleSkilfalse.SetActive(false);
            ControleSkiltrue.SetActive(true);
            skilcontroles01 = true;
            player.skiljump();
        }
    }

    public void GrificosSkil()
    {
        if(SkilsPoints>0 && !skilgraficos01)
        {
            SkilsPoints--;
            GraficosSkilPipe.SetActive(true);
            GraficosSkilfalse.SetActive(false);
            GraficosSkiltrue.SetActive(true);
            skilgraficos01 = true;
        }
    }

    public void MainSkil()
    {
        if(SkilsPoints>0 && !skilmain01)
        {
            SkilsPoints--;
            MainSkilPipe.SetActive(true);
            MainSkilfalse.SetActive(false);
            MainSkiltrue.SetActive(true);
            skilmain01 = true;
        }
    }
}
