using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChat : MonoBehaviour
{
    [SerializeField]
    private GameObject chat, nome1, nome2, text1, text2, text3, text4, firstButton, secondButton, thirdButton, fourthButton,cam3, cam4;
    [SerializeField]
    private Animator enemy;
    public static bool textOn = false;

    void Update()
    {
       if(textOn == true)
       {
            chat.SetActive(true);
            firstButton.SetActive(true);

            textOn = false;
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
        nome1.SetActive(false);
        nome2.SetActive(true); 

        text2.SetActive(false);
        text3.SetActive(true);

        secondButton.SetActive(false);
        thirdButton.SetActive(true);
    }

    public void thirdClick()
    {
        text3.SetActive(false);
        text4.SetActive(true);

        thirdButton.SetActive(false);
        fourthButton.SetActive(true);
    }

    public void fourthClick()
    {
        fourthButton.SetActive(false);
        chat.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(true);

        enemy.SetBool("PodeVoltar", true);
    }
}
