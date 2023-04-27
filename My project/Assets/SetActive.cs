using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
  public GameObject nextButton;

    void OnTriggerEnter(Collider other)  
    {
        nextButton.SetActive(true);
    }
}
