using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalSugador : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] GameObject interactText, suckerChat, text1, text2, inputOption, trueText3, falseText3, button1, button2,
        button3, button4, falseButton4, mainCamera, camera1, dirigivel, cutCanvas, oldZeppelin;
    [SerializeField] private InputField option;

    [SerializeField] private AudioSource enemyMusic, backgroundMusic, passing;

    bool exit = false;
    public static bool hasSucker = false, hasFinal;
    

    void Update()
    {

        if (exit == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                option.text = null;
                Diogo.isTalking = false;
                suckerChat.SetActive(false);
                button4.SetActive(false);
                falseText3.SetActive(false);
                button1.SetActive(true);
                falseButton4.SetActive(false);
                text1.SetActive(true);
                exit = false;
            }
        }

        if (hasSucker == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                suckerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Sugador"))
        {
            interactText.SetActive(true);
            hasSucker = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Sugador"))
        {
            interactText.SetActive(false);
            hasSucker = false;
        }
    }

    public void FirtstClick()
    {
        text1.SetActive(false);
        text2.SetActive(true);

        button1.SetActive(false);
        button2.SetActive(true);
    }

    public void SecondClick()
    {
        text2.SetActive(false);
        inputOption.SetActive(true);
        Cursor.visible = true;

        button2.SetActive(false);
        button3.SetActive(true);
    }

    public void ThirdClick()
    {
        if (option.text.ToUpper() == "OFF")
        {
            inputOption.SetActive(false);
            Cursor.visible = false;
            trueText3.SetActive(true);

            button3.SetActive(false);
            button4.SetActive(true);
        }
        else
        {
            inputOption.SetActive(false);
            Cursor.visible = false;
            falseText3.SetActive(true);

            button3.SetActive(false);
            falseButton4.SetActive(true);

            exit = true;
        }
    }

    public void FalseFourthClick()
    {
        option.text = null;
        inputOption.SetActive(true);
        falseText3.SetActive(false);
        Cursor.visible = true;

        button3.SetActive(true);
        falseButton4.SetActive(false);
    }

    public void FourthClick()
    {
        suckerChat.SetActive(false);
        mainCamera.SetActive(false);
        camera1.SetActive(true);
        dirigivel.SetActive(true);
        cutCanvas.SetActive(true);
        oldZeppelin.SetActive(false);
        backgroundMusic.Stop();
        enemyMusic.Play();
        passing.Play();

        hasFinal = true;
    }
}
