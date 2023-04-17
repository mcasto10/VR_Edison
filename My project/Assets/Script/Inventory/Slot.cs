using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Slot : MonoBehaviour
{
     public GameObject ItemInSlot;
     public Image slotImage;
     Color originalColor;

     // Start is called before the first frame update
     void Start()
     {
          slotImage = GetComponentInChildren<Image>();
          originalColor = slotImage.color;
     }

     private void OnTriggerStay(Collider other)
     {
          if (ItemInSlot != null) return;
          GameObject obj = other.gameObject;
          if (!IsItem(obj)) return;
          // gets current up state of a button 
          if (Input.GetButtonUp("XRI_Right_GripButton"))
          {
               InsertItem(obj);
          }
     }

     bool IsItem(GameObject obj)
     {
          return obj.GetComponent<Item>();
     }

     public void InsertItem(GameObject obj)
     {
          obj.GetComponent<Rigidbody>().isKinematic = true;
          obj.GetComponent<XRGrabInteractable>().SetKinematic(true);
          obj.GetComponent<XRGrabInteractable>().retainTransformParent = false;
          obj.transform.SetParent(gameObject.transform, true);
          obj.transform.localPosition = Vector3.zero;
          obj.transform.localEulerAngles = obj.GetComponent<Item>().slotRotation;
          obj.GetComponent<Item>().inSlot = true;
          obj.GetComponent<Item>().currentSlot = this;
          ItemInSlot = obj;
          slotImage.color = Color.gray;
     }
      
     public void ResetColor()
     {
          slotImage.color = originalColor;
     }

}
