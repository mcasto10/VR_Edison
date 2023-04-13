using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterA : MonoBehaviour
{
    public GameObject electricLine_A;
    setLedColor wan;
    setLedColor err;
    setLedColor io;
    setLedColor dc;

    void OnTriggerEnter(Collider other)
    {
      wan = GameObject.FindGameObjectWithTag("WAN").GetComponent<setLedColor>();
      err = GameObject.FindGameObjectWithTag("ERR").GetComponent<setLedColor>();
      io = GameObject.FindGameObjectWithTag("IO").GetComponent<setLedColor>();
      dc = GameObject.FindGameObjectWithTag("DC").GetComponent<setLedColor>();
      GameObject.FindGameObjectWithTag("DC").GetComponent<DCFlash>().enabled = false;
      GameObject.FindGameObjectWithTag("IO").GetComponent<IOPairingMode>().enabled = false;
      GameObject.FindGameObjectWithTag("IO").GetComponent<IOFlash>().enabled = true;

      electricLine_A.SetActive(true);
      wan.setWAN();
      err.setERR();
      io.setIO();
      dc.setDC();
    }
}
