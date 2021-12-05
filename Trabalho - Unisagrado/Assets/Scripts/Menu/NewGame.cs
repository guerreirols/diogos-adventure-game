using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    [SerializeField] GameObject background, exitButton;
    [SerializeField] private AudioSource select, backgroundMusic;

    public void NewGameButton()
    {
        backgroundMusic.Stop();
        select.Play();
        exitButton.SetActive(false);
        Time.timeScale = 1;
        Continue.continueGame = false;
        SaveController.gameLevel = 0;
        StartCoroutine(LoadNewGame());
    }

    IEnumerator LoadNewGame()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MainGame");

        while (!asyncLoad.isDone)
        {
            Cursor.visible = false;
            background.SetActive(true);
            yield return null;
        }
    }


}
