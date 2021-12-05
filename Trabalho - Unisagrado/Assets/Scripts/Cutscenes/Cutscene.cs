using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    [SerializeField]
    private AudioSource propeller, passing, doorSound, musicBackground, shot, enemyMusic;
    [SerializeField]
    private Animator enemy, door, cannon, cam;
    [SerializeField]
    private GameObject cam1, cam2, cam3, cam4, sphere, trans, black1, black2, zeppelinCut, zeppelinGame, gameCanvas,
        cameraRotation, gat2;
    public static bool isStoped = false, isEnter = false, rotateCannon = false, fire = false, rotateCam = false, endFire = false, light = false;

    void Start()
    {
        Diogo.isTalking = true;
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
    }


    void Update()
    {
        if(isStoped == true)
        {
            enemy.SetBool("PodeSair", true);
            door.SetBool("AbrirPorta", true);
            doorSound.Play();
            isStoped = false;
        }
        if (isEnter == true)
        {
            door.SetBool("FecharPorta", true);
            doorSound.Play();
            isEnter = false;
        }
        if (rotateCannon == true)
        {
            cannon.SetBool("PodeGirar", true);
        }
        if (fire == true)
        {
            sphere.SetActive(true);
        }
        if (rotateCam == true)
        {
            shot.Play();
            cam.SetBool("PodeIr", true);
            rotateCam = false;
        }
        if (endFire == true)
        {
            trans.SetActive(true);
            sphere.SetActive(false);           
        }
        if (light == true)
        {
            cam4.SetActive(false);
            cam1.SetActive(true);
            black1.SetActive(false);
            black2.SetActive(false);
            gameCanvas.SetActive(true);
            cameraRotation.SetActive(false);

            enemyMusic.Stop();
            propeller.Stop();
            musicBackground.Play();

            
            

            zeppelinGame.SetActive(true);
            zeppelinCut.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("CutGat"))
        {
            propeller.Play();
            passing.Stop();
            cam2.SetActive(true);
            cam3.SetActive(false);
        }
        if (col.gameObject.CompareTag("CutGat2"))
        {
            enemyMusic.Play();
            gat2.SetActive(true);
            passing.Play();
            cam2.SetActive(false);
            cam3.SetActive(true);         
        }
    }
}
