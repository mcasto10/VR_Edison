using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class DroppedItemSlot : MonoBehaviour
{
     public GameObject ItemInSlot;
     public GameObject text;

     // Start is called before the first frame update
     void Start()
    {
          gameObject.SetActive(false);
    }

     public void InsertItem(GameObject obj)
     {
          // clear item that is currently in the slot if there is any 
          if (ItemInSlot)
          {

               Destroy(ItemInSlot);
               ItemInSlot = null;
          }

          ItemInSlot = obj;

          gameObject.SetActive(true);
          // change the object's movement type to kinematic 
          //obj.GetComponent<XRGrabInteractable>().SetKinematic(true);
          obj.GetComponent<Rigidbody>().isKinematic = true;

          // object should not go back to the same parent
          obj.GetComponent<XRGrabInteractable>().retainTransformParent = false;

          // set parent to the slot
          obj.transform.SetParent(gameObject.transform, true);

          // set the local position and the angle
          obj.transform.localPosition = Vector3.zero;
          obj.transform.localEulerAngles = obj.GetComponent<Item>().slotRotation;

          // update item's information to indicate that it is in a slot and that it has been dropped 
          //obj.GetComponent<Item>().inSlot = true; 
          obj.GetComponent<Item>().isDropped = true;
          obj.GetComponent<Item>().DropSlot = gameObject;

          // change slot text to the object text 
          text.GetComponent<TextMeshProUGUI>().text = "Dropped: " + obj.GetComponent<Item>().ObjectName;
     }

     public void ResetSlot()
     {
          ItemInSlot = null;
          text.GetComponent<TextMeshProUGUI>().text = "Last Item Dropped Slot (Empty)";
          gameObject.SetActive(false);
     }
}
