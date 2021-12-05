using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmExit : MonoBehaviour
{
    [SerializeField]
    GameObject text, textChatFarmer, chatFarmer, text1, text2,
       text3, button1, button2, button3, button1Final, button2Final,
       mission, cowsCod, cowsCanvas, chatFazendeiroFinal, text1Final, 
        text2Final, exitWall, FazendeiroControl, diogo, saving;
    bool farmerChatOn = false;

    void Update()
    {
        if (farmerChatOn == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (CowSystem.cowScore == 10)
                {
                    cowsCanvas.SetActive(false);
                    cowsCod.SetActive(false);
                    chatFazendeiroFinal.SetActive(true);
                    exitWall.SetActive(false);
                    Diogo.isTalking = true;
                    textChatFarmer.SetActive(false);
                    SaveController.gameLevel = 2;
                    farmerChatOn = false;

                    PlayerPrefs.SetFloat("PosX", diogo.transform.position.x);
                    PlayerPrefs.SetFloat("PosY", diogo.transform.position.y);
                    PlayerPrefs.SetFloat("PosZ", diogo.transform.position.z);
                    PlayerPrefs.SetInt("GameLevel", SaveController.gameLevel);
                }
                
                else
                {
                    chatFarmer.SetActive(true);
                    textChatFarmer.SetActive(false);
                    Diogo.isTalking = true;
                }
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("SaidaGat"))
        {
            text.SetActive(true);
        }
        if (col.gameObject.CompareTag("ChatFazendeiro"))
        {
            textChatFarmer.SetActive(true);
            farmerChatOn = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("SaidaGat"))
        {
            text.SetActive(false);
        }
        if (col.gameObject.CompareTag("ChatFazendeiro"))
        {
            textChatFarmer.SetActive(false);
            farmerChatOn = false;
        }
    }

    public void FirtstClick()
    {
        text1.SetActive(false);
        text2.SetActive(true);

        button1.SetActive(false);
        button2.SetActive(true);
    }

    public void FirtstClickFinal()
    {
        text1Final.SetActive(false);
        text2Final.SetActive(true);

        button1Final.SetActive(false);
        button2Final.SetActive(true);
    }

    public void SecondClickFinal()
    {
        chatFazendeiroFinal.SetActive(false);
        FazendeiroControl.SetActive(false);
        saving.SetActive(true);
        Diogo.isTalking = false;
    }

    public void SecondClick()
    {
        text2.SetActive(false);
        text3.SetActive(true);

        button2.SetActive(false);
        button3.SetActive(true);
    }

    public void ThirdClick()
    {
        mission.SetActive(true);
        Diogo.isTalking = false;
        chatFarmer.SetActive(false);
        cowsCod.SetActive(true);
        cowsCanvas.SetActive(true);
    }
}

