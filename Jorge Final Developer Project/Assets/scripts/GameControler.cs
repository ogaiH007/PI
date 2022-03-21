using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public static GameControler instancia;
    public GameObject Menu;
    bool MenuAberto;

    public int Score;

    public Text ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        instancia = this;
        Score = PlayerPrefs.GetInt("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("Score", Score);
            if(!MenuAberto)
            {
                AbrirMenu();
            }
            else
            {
                FecharMenu();
            }
        }

        UpdateScore();
    }

    public void UpdateScore()
    {
        ScoreText.text = Score.ToString();
    }

    public void restart(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }

    public void FecharJogo()
    {
        Application.Quit();
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