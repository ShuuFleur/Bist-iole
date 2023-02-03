using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogues : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    public AudioSource voice;
    public AudioClip voiceS;

    public GameObject continueButton;

    void Start()
    {
        StartCoroutine(Type());
    }

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            voice.PlayOneShot(voiceS);
        }        
        
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);

        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            Debug.Log("Fin de l'index.");
        }

    }
}
