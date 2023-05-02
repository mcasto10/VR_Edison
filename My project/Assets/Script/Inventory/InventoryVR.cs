using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryVR : MonoBehaviour
{
     public GameObject Inventory;
     public GameObject MenuBar;
     public GameObject Anchor;
     bool UIActive;
     bool UIMenuActive;

     private void Start()
     {
          Inventory.SetActive(false);
          UIActive = false;
          MenuBar.SetActive(false);
          UIMenuActive = false;
     }

     private void Update()
     {
          if (Input.GetButtonDown("XRI_Left_SecondaryButton"))
          {
               UIActive = !UIActive;
               Inventory.SetActive(UIActive);
          }
          if (UIActive)
          {
               Inventory.transform.position = Anchor.transform.position;
               Inventory.transform.eulerAngles = new Vector3(Anchor.transform.eulerAngles.x + 15, Anchor.transform.eulerAngles.y, 0);
          }

           if (Input.GetButtonDown("XRI_Left_PrimaryButton"))
          {
               UIMenuActive = !UIMenuActive;
               MenuBar.SetActive(UIMenuActive);
          }
          if (UIMenuActive)
          {
               MenuBar.transform.position = Anchor.transform.position;
               MenuBar.transform.eulerAngles = new Vector3(Anchor.transform.eulerAngles.x + 15, Anchor.transform.eulerAngles.y, 0);
          }
     }
}
