using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class PoleMasterInventory : MonoBehaviour
{
     public GameObject ItemInSlot;

     public GameObject ItemInsertPoleMaster;

     public GameObject text;

  
void Start()
    {  
         InsertItem(ItemInsertPoleMaster);
    }

       public void InsertItem(GameObject obj)
     {

          ItemInSlot = obj;
        
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
          text.GetComponent<TextMeshProUGUI>().text = obj.GetComponent<Item>().ObjectName;
     }
}

