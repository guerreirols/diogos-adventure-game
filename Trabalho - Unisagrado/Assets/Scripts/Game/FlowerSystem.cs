using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowerSystem : MonoBehaviour
{
    [SerializeField] GameObject interactText, redFlower, blackFlower, blueFlower, brownFlower, greenFlower, orangeFlower,
        pinkFlower, purpleFlower,whiteFlower, yellowFlower, flowerChat, text1, text2, inputFlower, trueText3, falseText3,
        button1, button2, button3, button4, falseButton4;

    [SerializeField] private InputField flower;

    [SerializeField] bool exit = false, isRed = false, isBlack = false, isBlue = false, isBrown = false, isGreen = false, isOrange = false,
        isPink = false, isPurple = false, isWhite = false, isYellow = false;

    [SerializeField] Text score;

    [SerializeField] private Animator anim;

    [SerializeField] AudioSource itemColleted;

    public static int flowerScore = 0;

    void Update()
    {

        score.text = flowerScore.ToString();

        if(exit == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                flower.text = null;
                Diogo.isTalking = false;
                flowerChat.SetActive(false);
                button4.SetActive(false);
                falseText3.SetActive(false);
                button1.SetActive(true);
                falseButton4.SetActive(false);
                text1.SetActive(true);
                exit = false;
            }
        }

        if(isRed == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isBlack == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isBlue == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isBrown == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isGreen == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isOrange == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isPink == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isPurple == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isWhite == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isYellow == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                flowerChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Red"))
        {
            interactText.SetActive(true);
            isRed = true;
        }
        if (col.gameObject.CompareTag("Black"))
        {
            interactText.SetActive(true);
            isBlack = true;
        }
        if (col.gameObject.CompareTag("Blue"))
        {
            interactText.SetActive(true);
            isBlue = true;
        }
        if (col.gameObject.CompareTag("Brown"))
        {
            interactText.SetActive(true);
            isBrown = true;
        }
        if (col.gameObject.CompareTag("Green"))
        {
            interactText.SetActive(true);
            isGreen = true;
        }
        if (col.gameObject.CompareTag("Orange"))
        {
            interactText.SetActive(true);
            isOrange = true;
        }
        if (col.gameObject.CompareTag("Pink"))
        {
            interactText.SetActive(true);
            isPink = true;
        }
        if (col.gameObject.CompareTag("Orange"))
        {
            interactText.SetActive(true);
            isOrange = true;
        }
        if (col.gameObject.CompareTag("Purple"))
        {
            interactText.SetActive(true);
            isPurple = true;
        }
        if (col.gameObject.CompareTag("White"))
        {
            interactText.SetActive(true);
            isWhite = true;
        }
        if (col.gameObject.CompareTag("Yellow"))
        {
            interactText.SetActive(true);
            isYellow = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Red"))
        {
            interactText.SetActive(false);
            isRed = false;
        }
        if (col.gameObject.CompareTag("Black"))
        {
            interactText.SetActive(false);
            isBlack = false;
        }
        if (col.gameObject.CompareTag("Blue"))
        {
            interactText.SetActive(false);
            isBlue = false;
        }
        if (col.gameObject.CompareTag("Brown"))
        {
            interactText.SetActive(false);
            isBrown = false;
        }
        if (col.gameObject.CompareTag("Green"))
        {
            interactText.SetActive(false);
            isGreen = false;
        }
        if (col.gameObject.CompareTag("Orange"))
        {
            interactText.SetActive(false);
            isOrange = false;
        }
        if (col.gameObject.CompareTag("Pink"))
        {
            interactText.SetActive(false);
            isPink = false;
        }
        if (col.gameObject.CompareTag("Orange"))
        {
            interactText.SetActive(false);
            isOrange = false;
        }
        if (col.gameObject.CompareTag("Purple"))
        {
            interactText.SetActive(false);
            isPurple = false;
        }
        if (col.gameObject.CompareTag("White"))
        {
            interactText.SetActive(false);
            isWhite = false;
        }
        if (col.gameObject.CompareTag("Yellow"))
        {
            interactText.SetActive(false);
            isYellow = false;
        }
    }

    string FlowerColor()
    {
        if(isRed == true)
        {
            return "RED";           
        }
        else if (isBlack == true)
        {
            return "BLACK";
        }
        else if (isBlue == true)
        {
            return "BLUE";
        }
        else if (isBrown == true)
        {
            return "BROWN";
        }
        else if (isGreen == true)
        {
            return "GREEN";
        }
        else if (isOrange == true)
        {
            return "ORANGE";
        }
        else if (isPink == true)
        {
            return "PINK";
        }
        else if (isPurple == true)
        {
            return "PURPLE";
        }
        else if (isWhite == true)
        {
            return "WHITE";
        }
        else
        {
            return "YELLOW";
        }
    }

    GameObject FlowerObject()
    {
        if (isRed == true)
        {
            isRed = false;
            return redFlower;
        }
        else if (isBlack == true)
        {
            isBlack = false;
            return blackFlower;
        }
        else if (isBlue == true)
        {
            isBlue = false;
            return blueFlower;
        }
        else if (isBrown == true)
        {
            isBrown = false;
            return brownFlower;
        }
        else if (isGreen == true)
        {
            isGreen = false;
            return greenFlower;
        }
        else if (isOrange == true)
        {
            isOrange = false;
            return orangeFlower;
        }
        else if (isPink == true)
        {
            isPink = false;
            return pinkFlower;
        }
        else if (isPurple == true)
        {
            isPurple = false;
            return purpleFlower;
        }
        else if (isWhite == true)
        {
            isWhite = false;
            return whiteFlower;
        }
        else
        {
            isYellow = false;
            return yellowFlower;
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
        inputFlower.SetActive(true);
        Cursor.visible = true;

        button2.SetActive(false);
        button3.SetActive(true);
    }

    public void ThirdClick()
    {
        if (flower.text.ToUpper() == FlowerColor())
        {
            inputFlower.SetActive(false);
            Cursor.visible = false;
            trueText3.SetActive(true);

            button3.SetActive(false);
            button4.SetActive(true);
        }
        else
        {
            inputFlower.SetActive(false);
            Cursor.visible = false;
            falseText3.SetActive(true);

            button3.SetActive(false);
            falseButton4.SetActive(true);

            exit = true;
        }
    }

    public void FalseFourthClick()
    {
        flower.text = "";
        inputFlower.SetActive(true);
        falseText3.SetActive(false);
        Cursor.visible = true;

        button3.SetActive(true);
        falseButton4.SetActive(false);
    }

    public void FourthClick()
    {
        flower.text = "";
        Diogo.isTalking = false;
        flowerChat.SetActive(false);
        FlowerObject().SetActive(false);
        button4.SetActive(false);
        trueText3.SetActive(false);
        button1.SetActive(true);
        text1.SetActive(true);
        flowerScore++;
        itemColleted.Play();
    }

}
