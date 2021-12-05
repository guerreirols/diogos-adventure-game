using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveController : MonoBehaviour
{

    [SerializeField] GameObject cutsceneScripts, normalZepellin, camCut, mainCam, cutCanvas, startCanvas,
        chatStartDiogo, cityWall, exitCityScritps, flowers, farmWall, farmEnter, farmerCanvas, farmCodes, fruits,
        parkEnter,parkExit,scoutControl;
    [SerializeField] AudioSource backgroundMusic;

    public static int gameLevel = 0;

    void Start()
    {
        if(Continue.continueGame == true)
        {
            backgroundMusic.Play();
            camCut.SetActive(false);
            mainCam.SetActive(true);

            cutsceneScripts.SetActive(false);
            normalZepellin.SetActive(true);
            cutCanvas.SetActive(false);
            startCanvas.SetActive(true);
            chatStartDiogo.SetActive(false);

            if(gameLevel == 1)
            {
                cityWall.SetActive(false);
                exitCityScritps.SetActive(false);
                flowers.SetActive(false);
            }
            else if (gameLevel == 2)
            {
                cityWall.SetActive(false);
                exitCityScritps.SetActive(false);
                flowers.SetActive(false);
                farmWall.SetActive(false);
                farmEnter.SetActive(false);
                farmerCanvas.SetActive(false);
                farmCodes.SetActive(false);    
            }
            else if (gameLevel == 3)
            {
                cityWall.SetActive(false);
                exitCityScritps.SetActive(false);
                flowers.SetActive(false);
                farmWall.SetActive(false);
                farmEnter.SetActive(false);
                farmerCanvas.SetActive(false);
                farmCodes.SetActive(false);
                parkEnter.SetActive(false);
                parkExit.SetActive(false);
                scoutControl.SetActive(false);
                fruits.SetActive(false);
            }
        }
    }
}
