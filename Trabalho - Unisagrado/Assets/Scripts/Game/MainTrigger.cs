using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTrigger : MonoBehaviour
{

    [SerializeField] GameObject enterFarm, farmerCanvas, exitFarmCods, exitCityCods, jorgeCanvas, enterPark, parkCanvas,
        parkCods, finalCods, finalCanvas;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("FarmEnter"))
        {
            jorgeCanvas.SetActive(false);
            farmerCanvas.SetActive(true);
            exitFarmCods.SetActive(true);
            exitCityCods.SetActive(false);

            enterFarm.SetActive(false);
        }
        if (col.gameObject.CompareTag("ParkEnter"))
        {
            farmerCanvas.SetActive(false);
            enterPark.SetActive(false);
            exitFarmCods.SetActive(false);

            parkCanvas.SetActive(true);
            parkCods.SetActive(true);
        }
        if (col.gameObject.CompareTag("FinalEnter"))
        {
            parkCanvas.SetActive(false);
            parkCods.SetActive(false);

            finalCanvas.SetActive(true);
            finalCods.SetActive(true);
        }
    }
}
