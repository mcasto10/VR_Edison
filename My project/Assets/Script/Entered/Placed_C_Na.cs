using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placed_C_Na : MonoBehaviour
{
  public GameObject nextButton;

    void OnTriggerEnter(Collider other)  
    {
        nextButton.SetActive(true);
    }
}

