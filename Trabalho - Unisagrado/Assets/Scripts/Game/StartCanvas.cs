using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCanvas : MonoBehaviour
{
    [SerializeField] GameObject startChat, chat1, chat2, chat3, instructionText, endInstruction, mission, button1, button2, button3, cameraRotation;
    bool isFinished = false;
   
    void Update()
    {
        if(isFinished == true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                instructionText.SetActive(false);
                endInstruction.SetActive(false);
                mission.SetActive(true);
            }
        }
    }

    public void firtstClick()
    {
        chat1.SetActive(false);
        chat2.SetActive(true);

        button1.SetActive(false);
        button2.SetActive(true);
    }

    public void secondClick()
    {
        chat2.SetActive(false);
        chat3.SetActive(true);

        button2.SetActive(false);
        button3.SetActive(true);
    }

    public void thirdClick()
    {
        startChat.SetActive(false);

        instructionText.SetActive(true);
        endInstruction.SetActive(true);

        cameraRotation.SetActive(true);

        Diogo.isTalking = false;
        isFinished = true;
    }
}
