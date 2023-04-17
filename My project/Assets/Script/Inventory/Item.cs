
using UnityEngine;

public class Item : MonoBehaviour
{
     public bool inSlot;
     public Vector3 slotRotation = Vector3.zero;
     public Slot currentSlot;

     public void GrabFromSlot(GameObject obj)
     {
          if (obj.GetComponent<Item>() == null) return;
          if (obj.GetComponent<Item>().inSlot)
          {
               obj.GetComponentInParent<Slot>().ItemInSlot = null;
               obj.transform.parent = null;
               obj.GetComponent<Item>().inSlot = false;
               obj.GetComponent<Item>().currentSlot.ResetColor();
               obj.GetComponent<Item>().currentSlot = null;
          }
     }
     public void Update()
     {

     }
}
