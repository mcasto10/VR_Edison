using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetTrigger : MonoBehaviour
{

    public GameObject nextButton;

    void OnTriggerEnter(Collider other)  
    {
        nextButton.SetActive(true);

        GameObject.FindGameObjectWithTag("IO").GetComponent<IOPairingMode>().enabled = true;
    }
}
