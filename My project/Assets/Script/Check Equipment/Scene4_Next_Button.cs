using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4_Next_Button : MonoBehaviour
{
  public GameObject nextButton;

    void OnTriggerEnter(Collider other)  
    {
        nextButton.SetActive(true);
    }
}

