
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Item : MonoBehaviour
{
     public bool inSlot;
     public Vector3 slotRotation = Vector3.zero;
     public Slot currentSlot;
     public string ObjectName;
     public bool isDropped = false;
     public GameObject DropSlot = null; 
     public void GrabFromSlot()
     {
          if (inSlot)
          {
               currentSlot.ItemInSlot = null;
               gameObject.transform.parent = null;
               inSlot = false;
               currentSlot.ResetSlot();
               currentSlot = null;
               gameObject.GetComponent<XRGrabInteractable>().SetKinematic(false);
          }
          if (isDropped)
          {
               gameObject.GetComponent<XRGrabInteractable>().SetKinematic(false);
               DropSlot.GetComponent<DroppedItemSlot>().ResetSlot();
               isDropped = false;
               DropSlot = null;
          }
     }
}

