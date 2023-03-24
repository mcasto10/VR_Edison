using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setLedColor : MonoBehaviour
{
    TriggerEnterA triggerA;
    TriggerEnterA triggerB;
    TriggerEnterA triggerC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        triggerA = GameObject.Find("Catenary.005").GetComponent<TriggerEnterA>();
        triggerB = GameObject.Find("Catenary.006").GetComponent<TriggerEnterA>();
        triggerC = GameObject.Find("Catenary.004").GetComponent<TriggerEnterA>();
        if(triggerA.isConnected) {
            triggerA.isConnected = true;
            Debug.Log("Here");
        } else {
            Debug.Log("Not True");
        }
    }
}
