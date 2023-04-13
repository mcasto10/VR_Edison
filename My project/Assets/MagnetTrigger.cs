using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)  
    {
        GameObject.FindGameObjectWithTag("IO").GetComponent<IOPairingMode>().enabled = true;
    }
}
