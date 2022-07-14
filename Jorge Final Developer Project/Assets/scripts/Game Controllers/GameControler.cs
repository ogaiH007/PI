using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public static GameControler instancia;

    void Start()
    {
        instancia = this;
    }

    public void FecharJogo()
    {
        Application.Quit();
    }
    public void SetLife(int newlife)
    {
        PlayerPrefs.SetInt("PlayerLife", newlife);
    }
}