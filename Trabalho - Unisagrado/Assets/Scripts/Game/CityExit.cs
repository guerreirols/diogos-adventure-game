using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityExit : MonoBehaviour
{
    [SerializeField] GameObject text, textChatJorje, chatJorje, text1, text2,
        text3, text4, text5, button1, button2, button3, button4, button5, button1Final, button2Final,
        mission, flowersCod, flowersCanvas, chatJorgeFinal, text1Final, text2Final, exitWall, jorgeControl, diogo, saving;
    bool jorjeChatOn = false;
 
    void Update()
    {
        if(jorjeChatOn == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(FlowerSystem.flowerScore == 10)
                {
                    flowersCanvas.SetActive(false);
                    flowersCod.SetActive(false);
                    chatJorgeFinal.SetActive(true);
                    exitWall.SetActive(false);
                    Diogo.isTalking = true;
                    textChatJorje.SetActive(false);
                    SaveController.gameLevel = 1;

                    PlayerPrefs.SetFloat("PosX", diogo.transform.position.x);
                    PlayerPrefs.SetFloat("PosY", diogo.transform.position.y);
                    PlayerPrefs.SetFloat("PosZ", diogo.transform.position.z);
                    PlayerPrefs.SetInt("GameLevel", SaveController.gameLevel);
                }
                else
                {
                    chatJorje.SetActive(true);
                    textChatJorje.SetActive(false);
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
        if (col.gameObject.CompareTag("ChatJorje"))
        {
            textChatJorje.SetActive(true);
            jorjeChatOn = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("SaidaGat"))
        {
            text.SetActive(false);
        }
        if (col.gameObject.CompareTag("ChatJorje"))
        {
            textChatJorje.SetActive(false);
            jorjeChatOn = false;
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
        chatJorgeFinal.SetActive(false);
        jorgeControl.SetActive(false);
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
        text3.SetActive(false);
        text4.SetActive(true);

        button3.SetActive(false);
        button4.SetActive(true);
    }

    public void FourthClick()
    {
        text4.SetActive(false);
        text5.SetActive(true);

        button4.SetActive(false);
        button5.SetActive(true);
    }

    public void FifthClick()
    {
        flowersCanvas.SetActive(true);
        flowersCod.SetActive(true);
        chatJorje.SetActive(false);
        mission.SetActive(true);
        Diogo.isTalking = false;
    }
}
