using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowSystem : MonoBehaviour
{
    [SerializeField] private Animator anim;

    [SerializeField]
    GameObject interactText, cowChat, text1, text2, inputCow, trueText3, falseText3, button1, button2, button3, button4, falseButton4;
    [SerializeField] private InputField cow;

    [SerializeField]
    bool exit = false;
    public static bool hasCow = false;
    public static int cowScore = 0, cowID = 0;
    [SerializeField] Text score;

    void Update()
    {

        score.text = cowScore.ToString();

        if (exit == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                cow.text = null;
                Diogo.isTalking = false;
                cowChat.SetActive(false);
                button4.SetActive(false);
                falseText3.SetActive(false);
                button1.SetActive(true);
                falseButton4.SetActive(false);
                text1.SetActive(true);
                exit = false;
            }
        }

        if (hasCow == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                cowChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Cow"))
        {
            interactText.SetActive(true);
            hasCow = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Cow"))
        {
            interactText.SetActive(false);
            hasCow = false;
        }
    }

    string TrueNumber()
    {
        if(cowScore == 0)
        {
            return "ONE";
        }
        else if(cowScore == 1)
        {
            return "TWO";
        }
        else if(cowScore == 2)
        {
            return "THREE";
        }
        else if(cowScore == 3)
        {
            return "FOUR";
        }
        else if(cowScore == 4)
        {
            return "FIVE";
        }
        else if(cowScore == 5)
        {
            return "SIX";
        }
        else if(cowScore == 6)
        {
            return "SEVEN";
        }
        else if(cowScore == 7)
        {
            return "EIGHT";
        }
        else if(cowScore == 8)
        {
            return "NINE";
        }
        else
        {
            return "TEN";
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
        inputCow.SetActive(true);
        Cursor.visible = true;

        button2.SetActive(false);
        button3.SetActive(true);
    }

    public void ThirdClick()
    {
        if (cow.text.ToUpper() == TrueNumber())
        {
            inputCow.SetActive(false);
            Cursor.visible = false;
            trueText3.SetActive(true);

            button3.SetActive(false);
            button4.SetActive(true);
        }
        else
        {
            inputCow.SetActive(false);
            Cursor.visible = false;
            falseText3.SetActive(true);

            button3.SetActive(false);
            falseButton4.SetActive(true);

            exit = true;
        }
    }

    public void FalseFourthClick()
    {
        cow.text = "";
        inputCow.SetActive(true);
        falseText3.SetActive(false);
        Cursor.visible = true;

        button3.SetActive(true);
        falseButton4.SetActive(false);
    }

    public void FourthClick()
    {
        cow.text = "";
        Diogo.isTalking = false;
        cowChat.SetActive(false);
        button4.SetActive(false);
        trueText3.SetActive(false);
        button1.SetActive(true);
        text1.SetActive(true);
        cowScore++;
        cowID = 1;
    }
}
