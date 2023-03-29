using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterA : MonoBehaviour
{
    public GameObject electricLine_A;
    setLedColor[] leds = new setLedColor[4];
    string[] spheres = {"SphereZero", "SphereOne", "SphereTwo", "SphereThree"};

    void Start() {
      for(int i = 0; i < spheres.Length; i++) {
        leds[i] = GameObject.FindGameObjectWithTag(spheres[i]).GetComponent<setLedColor>();
      }
    }

    void OnTriggerEnter(Collider other)
    {
      electricLine_A.SetActive(true);
      foreach(setLedColor led in leds) {
        led.setGreen();
      }
    }
}
