using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterA : MonoBehaviour
{
    public GameObject electricLine_A;

      public GameObject nextButton;

    void OnTriggerEnter(Collider other)
    {
      GameObject.FindGameObjectWithTag("IO").GetComponent<IOPairingMode>().StopPairingMode();
      GameObject.FindGameObjectWithTag("IO").GetComponent<IOPairingMode>().enabled = false;
      GameObject.FindGameObjectWithTag("IO").GetComponent<IOFlash>().enabled = true;
      electricLine_A.SetActive(true);
      nextButton.SetActive(true);
    }
}
