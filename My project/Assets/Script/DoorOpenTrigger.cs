using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script senses if an object enters the trigger
// when object enters trigger, invoke function

public class DoorOpenTrigger : MonoBehaviour
{
    public Collider Target; // collider of object to enter the trigger range
    public GameObject InvisibleObject; // new dialogue box that will pop up when triggered 
    public void OnTriggerEnter(Collider other) {
        if (other == Target)
        {
            Debug.Log("door handle collided");
            InvisibleObject.SetActive(true);
        }
    }
}
