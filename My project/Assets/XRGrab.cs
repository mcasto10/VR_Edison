using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrab : MonoBehaviour
{

    private XRGrabInteractable interactable;
    
    private void Start()
    {

     interactable = GetComponent<XRGrabInteractable>();

    }

     private void Update()
    {
        if (interactable.isSelected)
        {
            if (gameObject.GetComponent<Item> () == null) return; 

            if (gameObject.GetComponent<Item>().inSlot) {
                gameObject.GetComponentInParent<Slot>().ItemInSlot = null; 
                gameObject.transform.parent = null;
                gameObject.GetComponent<Item>().inSlot = false;
                gameObject.GetComponent<Item>().currentSlot.ResetColor();
                gameObject.GetComponent<Item>().currentSlot = null;
            }
        }
    }

    
}
