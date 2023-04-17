
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


     public class Item : MonoBehaviour
     {
          public bool inSlot;
          public Vector3 slotRotation = Vector3.zero;
          public Slot currentSlot;

          public void GrabFromSlot()
          {
               //if (obj.GetComponent<Item>() == null) return;
               //if (obj.GetComponent<Item>().inSlot)
               //{
               //     obj.GetComponentInParent<Slot>().ItemInSlot = null;
               //     obj.transform.parent = null;
               //     obj.GetComponent<Item>().inSlot = false;
               //     obj.GetComponent<Item>().currentSlot.ResetColor();
               //     obj.GetComponent<Item>().currentSlot = null;
               //}
               if (inSlot == true)
               {
                    currentSlot.ItemInSlot = null;
                    gameObject.transform.parent = null;
                    inSlot = false;
                    currentSlot.ResetColor();
                    currentSlot = null;
                    gameObject.GetComponent<XRGrabInteractable>().SetKinematic(false);
               }
          }
          public void Update()
          {

          }
     }

