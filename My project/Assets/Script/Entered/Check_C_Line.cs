using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_C_Line : MonoBehaviour
{
  public GameObject nextButton;

    void OnTriggerEnter(Collider other)  
    {
        nextButton.SetActive(true);
    }
}

