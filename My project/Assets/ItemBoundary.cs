using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoundary : MonoBehaviour
{
     public GameObject DropSlot;
     private void OnTriggerEnter(Collider other)
     {
          // if an item is dropped into this area, it will insert into dropped item slot
          if (other.GetComponent<Item>())
          {
               DropSlot.GetComponent<DroppedItemSlot>().InsertItem(other.gameObject);
          }
     }
}
