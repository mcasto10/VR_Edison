using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public GameObject textAppear;

     // Checking to see if an object enters the specific zone
    public void OnTriggerEnter_A()
    {        
        textAppear.SetActive(true);
        Debug.Log("Object Entered the trigger");
    }

     public void OnTriggerEnter_B()
    {
        textAppear.SetActive(true);
        // Debug.Log("Object Entered the trigger");
    }

      public void OnTriggerEnter_C()
    {
        textAppear.SetActive(true);
        // Debug.Log("Object Entered the trigger");
    }
}
