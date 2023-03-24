using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterPoleMaster : MonoBehaviour
{
    public GameObject polemaster;
    
    public GameObject polemasterRoate;

    void OnTriggerEnter(Collider other)
    {
      polemasterRoate.SetActive(true);
      polemaster.SetActive(false);
    }
}
