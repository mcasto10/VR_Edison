using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryVR : MonoBehaviour
{
     public GameObject Inventory;
     public GameObject Anchor;
     bool UIActive;

     private void Start()
     {
          Inventory.SetActive(false);
          UIActive = false;
     }

     private void Update()
     {
          if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
          {
               UIActive = !UIActive;
               Inventory.SetActive(UIActive);
          }
          if (UIActive)
          {
               Inventory.transform.position = Anchor.transform.position;
               Inventory.transform.eulerAngles = new Vector3(Anchor.transform.eulerAngles.x + 15, Anchor.transform.eulerAngles.y, 0);
          }
     }
}
