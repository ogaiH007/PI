using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{
    public static GameControler instancia;
    public GameObject menu;
    public GameObject pauseb;
    
    // Start is called before the first frame update
    void Start()
    {
        instancia = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }

    public void fechar()
    {
        Application.Quit();
    }

    public void abrirmenu()
    {
        menu.SetActive(true);
        pauseb.SetActive(false);
    }
    public void fecharmenu()
    {
        menu.SetActive(false);
        pauseb.SetActive(true);
    }
}
