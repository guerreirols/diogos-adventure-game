using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitSystem : MonoBehaviour
{

    [SerializeField] private Animator anim;

    [SerializeField] GameObject interactText, watermelon, strawberry, peach, peanut, pear, cherry, banana, apple,
        avocado, lemon, fruitChat, text1, text2, inputFruit, trueText3, falseText3, button1, button2, button3,
        button4, falseButton4;

    [SerializeField] bool exit = false, isWatermelon = false, isStrawberry = false, isPeach = false, isPeanut = false,
        isPear = false, isCherry = false, isBanana = false, isApple = false, isAvocado = false, isLemon = false;
    
    [SerializeField] InputField fruit;
    [SerializeField] Text score;

    [SerializeField] AudioSource itemSound;

    public static int fruitScore = 0;

    void Update()
    {

        score.text = fruitScore.ToString();

        if (exit == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                fruit.text = null;
                Diogo.isTalking = false;
                fruitChat.SetActive(false);
                button4.SetActive(false);
                falseText3.SetActive(false);
                button1.SetActive(true);
                falseButton4.SetActive(false);
                text1.SetActive(true);
                exit = false;
            }
        }

        if (isWatermelon == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isStrawberry == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isPeach == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isPeanut == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isPear == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isCherry == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isBanana == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isApple == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isAvocado == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
        else if (isLemon == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetInteger("transition", 0);
                Diogo.moveDirection = Vector3.zero;
                fruitChat.SetActive(true);
                interactText.SetActive(false);
                Diogo.isTalking = true;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Watermelon"))
        {
            interactText.SetActive(true);
            isWatermelon = true;
        }
        if (col.gameObject.CompareTag("Strawberry"))
        {
            interactText.SetActive(true);
            isStrawberry = true;
        }
        if (col.gameObject.CompareTag("Peach"))
        {
            interactText.SetActive(true);
            isPeach = true;
        }
        if (col.gameObject.CompareTag("Peanut"))
        {
            interactText.SetActive(true);
            isPeanut = true;
        }
        if (col.gameObject.CompareTag("Pear"))
        {
            interactText.SetActive(true);
            isPear = true;
        }
        if (col.gameObject.CompareTag("Cherry"))
        {
            interactText.SetActive(true);
            isCherry = true;
        }
        if (col.gameObject.CompareTag("Banana"))
        {
            interactText.SetActive(true);
            isBanana = true;
        }
        if (col.gameObject.CompareTag("Apple"))
        {
            interactText.SetActive(true);
            isApple = true;
        }
        if (col.gameObject.CompareTag("Avocado"))
        {
            interactText.SetActive(true);
            isAvocado = true;
        }
        if (col.gameObject.CompareTag("Lemon"))
        {
            interactText.SetActive(true);
            isLemon = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Watermelon"))
        {
            interactText.SetActive(false);
            isWatermelon = false;
        }
        if (col.gameObject.CompareTag("Strawberry"))
        {
            interactText.SetActive(false);
            isStrawberry = false;
        }
        if (col.gameObject.CompareTag("Peach"))
        {
            interactText.SetActive(false);
            isPeach = false;
        }
        if (col.gameObject.CompareTag("Peanut"))
        {
            interactText.SetActive(false);
            isPeanut = false;
        }
        if (col.gameObject.CompareTag("Pear"))
        {
            interactText.SetActive(false);
            isPear = false;
        }
        if (col.gameObject.CompareTag("Cherry"))
        {
            interactText.SetActive(false);
            isCherry = false;
        }
        if (col.gameObject.CompareTag("Banana"))
        {
            interactText.SetActive(false);
            isBanana = false;
        }
        if (col.gameObject.CompareTag("Apple"))
        {
            interactText.SetActive(false);
            isApple = false;
        }
        if (col.gameObject.CompareTag("Avocado"))
        {
            interactText.SetActive(false);
            isAvocado = false;
        }
        if (col.gameObject.CompareTag("Lemon"))
        {
            interactText.SetActive(false);
            isLemon = false;
        }
    }

    string FruitName()
    {
        if (isWatermelon == true)
        {
            return "WATERMELON";
        }
        else if (isStrawberry == true)
        {
            return "STRAWBERRY";
        }
        else if (isPeach == true)
        {
            return "PEACH";
        }
        else if (isPeanut == true)
        {
            return "PEANUT";
        }
        else if (isPear == true)
        {
            return "PEAR";
        }
        else if (isCherry == true)
        {
            return "CHERRY";
        }
        else if (isBanana == true)
        {
            return "BANANA";
        }
        else if (isApple == true)
        {
            return "APPLE";
        }
        else if (isAvocado == true)
        {
            return "AVOCADO";
        }
        else
        {
            return "LEMON";
        }
    }

    GameObject FruitObject()
    {
        if (isWatermelon == true)
        {
            isWatermelon = false;
            return watermelon;
        }
        else if (isStrawberry == true)
        {
            isStrawberry = false;
            return strawberry;
        }
        else if (isPeach == true)
        {
            isPeach = false;
            return peach;
        }
        else if (isPeanut == true)
        {
            isPeanut = false;
            return peanut;
        }
        else if (isPear == true)
        {
            isPear = false;
            return pear;
        }
        else if (isCherry == true)
        {
            isCherry = false;
            return cherry;
        }
        else if (isBanana == true)
        {
            isBanana = false;
            return banana;
        }
        else if (isApple == true)
        {
            isApple = false;
            return apple;
        }
        else if (isAvocado == true)
        {
            isAvocado = false;
            return avocado;
        }
        else
        {
            isLemon = false;
            return lemon;
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
        inputFruit.SetActive(true);
        Cursor.visible = true;

        button2.SetActive(false);
        button3.SetActive(true);
    }

    public void ThirdClick()
    {
        if (fruit.text.ToUpper() == FruitName())
        {
            inputFruit.SetActive(false);
            Cursor.visible = false;
            trueText3.SetActive(true);

            button3.SetActive(false);
            button4.SetActive(true);
        }
        else
        {
            inputFruit.SetActive(false);
            Cursor.visible = false;
            falseText3.SetActive(true);

            button3.SetActive(false);
            falseButton4.SetActive(true);

            exit = true;
        }
    }

    public void FalseFourthClick()
    {
        fruit.text = "";
        inputFruit.SetActive(true);
        falseText3.SetActive(false);
        Cursor.visible = true;

        button3.SetActive(true);
        falseButton4.SetActive(false);
    }

    public void FourthClick()
    {
        fruit.text = "";
        Diogo.isTalking = false;
        fruitChat.SetActive(false);
        FruitObject().SetActive(false);
        button4.SetActive(false);
        trueText3.SetActive(false);
        button1.SetActive(true);
        text1.SetActive(true);
        fruitScore++;
        itemSound.Play();
    }

}
