using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterA : MonoBehaviour
{
    public GameObject electricLine_A;
    public bool isConnected;

    void OnTriggerEnter(Collider other)
    {
      electricLine_A.SetActive(true);
      isConnected = true;
    }
}
