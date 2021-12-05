using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public static bool continueGame;
    [SerializeField] GameObject background, saveButtonOff, exitButton;
    [SerializeField] private AudioSource select, backgroundMusic;

    private void Start()
    {

        Cursor.visible = true;

        if (PlayerPrefs.HasKey("PosX"))
        {
            saveButtonOff.SetActive(false);
        }       
    }

    public void ContinueButton()
    {
        select.Play();
        backgroundMusic.Stop();
        continueGame = true;
        StartCoroutine(LoadGame());
        exitButton.SetActive(false);
    }

    IEnumerator LoadGame()
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
