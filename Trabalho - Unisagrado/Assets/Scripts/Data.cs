using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    GameObject[] datas;

    public static float posX, posY, posZ;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("PosX"))
        {
            posX = PlayerPrefs.GetFloat("PosX");
        }


        //

        if (PlayerPrefs.HasKey("PosY"))
        {
            posY = PlayerPrefs.GetFloat("PosY");
        }


        //

        if (PlayerPrefs.HasKey("PosZ"))
        {
            posZ = PlayerPrefs.GetFloat("PosZ");
        }

        //

        if (PlayerPrefs.HasKey("GameLevel"))
        {
            SaveController.gameLevel = PlayerPrefs.GetInt("GameLevel");
        }
    }
}
