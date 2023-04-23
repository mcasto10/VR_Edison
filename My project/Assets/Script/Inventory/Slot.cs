using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
public class Slot : MonoBehaviour
{
     public GameObject ItemInSlot;
     public Image slotImage;

     public GameObject Background;
     public Material EmptyMaterial;
     public Material HoverMaterial;
     public Material NonEmptyMaterial;

     public GameObject text;


     private GameObject CollidedObject;

     // Start is called before the first frame update
     void Start()
     {
          slotImage = GetComponentInChildren<Image>();
     }

     private void Update()
     {
     }


     private void OnTriggerStay(Collider other)
     {
          
          // if there is an item in the slot, return 
          if (ItemInSlot != null) return;

          GameObject obj = other.gameObject;

          // if the collided object is not an item, return
          if (!IsItem(obj)) return;


          CollidedObject = obj;
          // if an item is near, change color to hover material
          Background.GetComponent<Image>().material = HoverMaterial;

          // if the user released the object from the right hand, insert the item into the slot 
          if (Input.GetButtonUp("XRI_Right_GripButton"))
          {
               InsertItem(obj);
          }
          
     }

     private void OnTriggerExit(Collider other)
     {
          if (ItemInSlot == null)
               ResetSlot();
     }

     bool IsItem(GameObject obj)
     {
          // returns true if obj has a component "Item"
          return obj.GetComponent<Item>();
     }

     public void InsertItem(GameObject obj)
     {
          //obj.GetComponent<Rigidbody>().isKinematic = true;

          // change the object's movement type to kinematic 
          obj.GetComponent<XRGrabInteractable>().SetKinematic(true);

          // object should not go back to the same parent
          obj.GetComponent<XRGrabInteractable>().retainTransformParent = false;

          // set parent to the slot
          obj.transform.SetParent(gameObject.transform, true);

          // set the local position and the angle
          obj.transform.localPosition = Vector3.zero;
          obj.transform.localEulerAngles = obj.GetComponent<Item>().slotRotation;

          // update slot information to indicate that there is an object and set the slot of the object
          obj.GetComponent<Item>().inSlot = true;
          obj.GetComponent<Item>().currentSlot = this;
          ItemInSlot = obj;

          // change material of the slot 
          Background.GetComponent<Image>().material = NonEmptyMaterial;

          // change slot text to the object text 
          text.GetComponent<TextMeshProUGUI>().text = obj.GetComponent<Item>().ObjectName;
     }
      
     public void ResetSlot()
     {

          //reset color
          Background.GetComponent<Image>().material = EmptyMaterial;

          //reset text 
          text.GetComponent<TextMeshProUGUI>().text = "Empty Slot";


     }

}
