using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour
{

    // public OnTrigger trigger; 

    public GameObject electricLine_A;

    void OnTriggerEnter(Collider other)
    {
      electricLine_A.SetActive(true);
        // OnTrigger trigger = new OnTrigger();

        // objectPass.GetComponent<Box_Collider>().enabled = false;

        // trigger.OnTriggerEnter_A(objectPass);
    }

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
