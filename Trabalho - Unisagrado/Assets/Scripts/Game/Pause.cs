using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] GameObject pauseCanvas, confirmCanvas;
    [SerializeField] float X, Y, Z;
    [SerializeField] private AudioSource select;


    public static bool isPaused = false;

    private void Start()
    {
        Cursor.visible = false;

        if (Continue.continueGame == true)
        {
            transform.position = new Vector3(Data.posX, Data.posY, Data.posZ);
        }
    }


    void Update()
    {
        Data.posX = transform.position.x;
        Data.posY = transform.position.y;
        Data.posZ = transform.position.z;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused == false && Diogo.isTalking == false)
            {              
                PauseGame();
            }
            else if(isPaused == true && Diogo.isTalking == false)
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        select.Play();
        
        Cursor.visible = true;
        isPaused = true;
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        select.Play();
        anim.SetInteger("transition", 0);
        Diogo.moveDirection = Vector3.zero;
        Cursor.visible = false;
        isPaused = false;
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void ExitButton()
    {
        select.Play();
        confirmCanvas.SetActive(true);
    }


    public void BackPause()
    {
        select.Play();
        confirmCanvas.SetActive(false);
    }
}
