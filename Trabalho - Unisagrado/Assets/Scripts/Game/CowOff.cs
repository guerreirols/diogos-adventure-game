using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowOff : MonoBehaviour
{
    bool isHere = false;

    private void Update()
    {
        if (CowSystem.cowID == 1 && isHere == true)
        {
            print("aaa");
            CowSystem.hasCow = false;
            CowSystem.cowID = 0;
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isHere = true;
        }       
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isHere = false;
        }
    }
}
