using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterA : MonoBehaviour
{
    public GameObject electricLine_A;

    void OnTriggerEnter(Collider other)
    {
      GameObject.FindGameObjectWithTag("IO").GetComponent<IOPairingMode>().StopPairingMode();
      GameObject.FindGameObjectWithTag("DC").GetComponent<DCFlash>().StopFlash();
      GameObject.FindGameObjectWithTag("IO").GetComponent<IOPairingMode>().enabled = false;
      GameObject.FindGameObjectWithTag("IO").GetComponent<IOFlash>().enabled = true;
      GameObject.FindGameObjectWithTag("DC").GetComponent<DCFlash>().StartFlash();
      electricLine_A.SetActive(true);
    }
}
