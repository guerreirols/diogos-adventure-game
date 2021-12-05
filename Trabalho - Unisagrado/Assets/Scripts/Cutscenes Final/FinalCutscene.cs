using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalCutscene : MonoBehaviour
{
    [SerializeField]
    GameObject enemyChat, text1, text2, text3, firstButton, secondButton, thirdButton, cam1, cam2, cam3,
        zepellinObj, finalCanvas, imageDA, thanks, background, creditsCanvas;
    [SerializeField] Animator enemy, door, zepellin;

    [SerializeField]  private AudioSource propeller, passing, doorSound, musicBackground, enemyMusic;


    public static bool textOn, isEnter, finalOk, downOk, showCredits, showThanks, endGame;

    void Update()
    {
        if (textOn == true)
        {
            enemyChat.SetActive(true);
            textOn = false;
        }
        if (isEnter == true)
        {
            door.SetBool("FecharPorta", true);
            doorSound.Play();
            isEnter = false;
        }
        if (finalOk == true)
        {
            propeller.Stop();
            enemyMusic.Stop();
            musicBackground.Play();
            print("ok");
            cam2.SetActive(false);
            cam3.SetActive(true);
            finalOk = false;
            finalCanvas.SetActive(false);
            creditsCanvas.SetActive(true);      
        }
        if (downOk == true)
        {
            passing.Stop();
            propeller.Play();
            cam1.SetActive(false);
            cam2.SetActive(true);
            enemy.SetBool("PodeSair", true);
            door.SetBool("AbrirPorta", true);
            doorSound.Play();
            downOk = false;
        }
        if (showCredits == true)
        {
            imageDA.SetActive(true);
            showCredits = false;
        }
        if (showThanks == true)
        {
            imageDA.SetActive(false);
            thanks.SetActive(true);
            showThanks = false;
        }
        if (endGame == true)
        {
            Application.Quit();
        }
    }

    public void firtstClick()
    {
        text1.SetActive(false);
        text2.SetActive(true);

        firstButton.SetActive(false);
        secondButton.SetActive(true);
    }

    public void secondClick()
    {
        text2.SetActive(false);
        text3.SetActive(true);

        secondButton.SetActive(false);
        thirdButton.SetActive(true);
    }

    public void thirdClick()
    {
        enemy.SetBool("PodeVoltar", true);
        enemyChat.SetActive(false);
    }
}
