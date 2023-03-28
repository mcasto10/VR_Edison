using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterA : MonoBehaviour
{
    public GameObject electricLine_A;
    setLedColor myLed;

    void Start() {
      myLed = GameObject.FindGameObjectWithTag("SphereZero").GetComponent<setLedColor>();
    }

    void OnTriggerEnter(Collider other)
    {
      electricLine_A.SetActive(true);
      myLed.setGreen();
    }

}
