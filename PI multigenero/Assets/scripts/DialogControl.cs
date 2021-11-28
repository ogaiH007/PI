using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj;
    public Image profile;
    public Text speechText;
    public Text actorNameText;

    [Header("Settings")]
    public float typingSpeed;

    public void Speech(Sprite p, string txt, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = p;
        speechText.text = txt;
        actorNameText.text = actorName;
    }
}
