
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


     public class Item : MonoBehaviour
     {
          public bool inSlot;
          public Vector3 slotRotation = Vector3.zero;
          public Slot currentSlot;

          public void GrabFromSlot()
          {
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
     }

