using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontuationController : MonoBehaviour
{
    public static PontuationController instancia;

    public int Score;

    public Text ScoreText;

    void Start()
    {
        instancia = this;
        Score = PlayerPrefs.GetInt("Score");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("Score", Score);
        }
        UpdateScore();
        PlayerPrefs.SetInt("Score", Score);
    }

    public void UpdateScore()
    {
        ScoreText.text = Score.ToString();
    }
}
