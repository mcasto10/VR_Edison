using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetEntered : MonoBehaviour
{
  public GameObject nextButton;

  public GameObject nextNextButton;

    void OnTriggerEnter(Collider other)  
    {
        nextButton.SetActive(true);
    }

     void OnTriggerEnter2(Collider other)  
    {
        nextNextButton.SetActive(true);
    }
}

