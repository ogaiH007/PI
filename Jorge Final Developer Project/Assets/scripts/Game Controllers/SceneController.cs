using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    public static SceneController instancia;

    void Start()
    {
        instancia = this;
    }

    public void LevelSelect(string LvlName)
    {
        SceneManager.LoadScene(LvlName);
    }
}
