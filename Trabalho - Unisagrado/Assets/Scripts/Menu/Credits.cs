using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    [SerializeField]
    private GameObject background, credits;

    [SerializeField] private AudioSource select;


    public void CreditsButton()
    {
        select.Play();
        background.SetActive(true);
        credits.SetActive(true);   
        Cursor.visible = false;
    }

    void Update()
    {
        if(CloseCredits.hasFinished == true || Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            background.SetActive(false);
            credits.SetActive(false);
            CloseCredits.hasFinished = false;
        }
    }
}
