using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class Intered : XRGrabInteractable
{
    // Override the OnSelectEntered method
    protected override void OnSelectEntered(SelectEnterEventArgs  interactor)
    {
        base.OnSelectEntered(interactor);
        
        // Add your code here to perform actions when the object is picked up
        Debug.Log("Object picked up by XR Grab Interactor");

        
            if(gameObject.GetComponent<Item>() == null) return;
            if(gameObject.GetComponent<Item>().inSlot) {
                gameObject.GetComponentInParent<Slot>().ItemInSlot = null;
                gameObject.transform.parent = null;
                gameObject.GetComponent<Item>().inSlot = false;
                gameObject.GetComponent<Item>().currentSlot = null;
            }

    }
}
