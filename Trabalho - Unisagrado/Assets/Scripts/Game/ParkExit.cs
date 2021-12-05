using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkExit : MonoBehaviour
{
    [SerializeField]
    GameObject text, textChatScout, chatScout, text1, text2,
        text3, text4, button1, button2, button3, button4, button1Final, button2Final,
        mission, fruitCod, fruitCanvas, chatScoutFinal, text1Final, text2Final, exitWall, scoutControl, diogo, saving;
    bool scoutChatOn = false;

    void Update()
    {
        if (scoutChatOn == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (FruitSystem.fruitScore == 10)
                {
                    fruitCanvas.SetActive(false);
                    fruitCod.SetActive(false);
                    chatScoutFinal.SetActive(true);
                    exitWall.SetActive(false);
                    Diogo.isTalking = true;
                    textChatScout.SetActive(false);
                    SaveController.gameLevel = 3;
                    PlayerPrefs.SetFloat("PosX", diogo.transform.position.x);
                    PlayerPrefs.SetFloat("PosY", diogo.transform.position.y);
                    PlayerPrefs.SetFloat("PosZ", diogo.transform.position.z);
                    PlayerPrefs.SetInt("GameLevel", SaveController.gameLevel);
                }
                else
                {
                    chatScout.SetActive(true);
                    textChatScout.SetActive(false);
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
        if (col.gameObject.CompareTag("ChatAdestr"))
        {
            textChatScout.SetActive(true);
            scoutChatOn = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("SaidaGat"))
        {
            text.SetActive(false);
        }
        if (col.gameObject.CompareTag("ChatAdestr"))
        {
            textChatScout.SetActive(false);
            scoutChatOn = false;
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
        chatScoutFinal.SetActive(false);
        scoutControl.SetActive(false);
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
        fruitCanvas.SetActive(true);
        fruitCod.SetActive(true);
        chatScout.SetActive(false);
        mission.SetActive(true);
        Diogo.isTalking = false;
    }
}
