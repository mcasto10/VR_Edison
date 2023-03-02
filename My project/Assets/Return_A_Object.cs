// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.XR;
// using System;

// public class Return_A_Object : MonoBehaviour
// {
//     // public List<GameObject> controllerPrefabs;
//     // public event EventHandler OnPickedup;
//     // public event EventHandler OnLetGo;
//     // private bool HasObject = false;
//     // private InputDevice targetDevice;

//     // private Interactable interactable;
//     public bool isGrabbed;
//     private GameObject heldObject;

//     public GameObject smartNavigator_A;

//     // Checking to see if an object enters the specific zone
//     void OnTriggerEnter_A(Collider other)
//     {
//         smartNavigator_A.setActive(true);
//         // Debug.Log("Object Entered the trigger");
//     }

//      void OnTriggerEnter_B(Collider other)
//     {
//         smartNavigator_B.setActive(true);
//         // Debug.Log("Object Entered the trigger");
//     }

//       void OnTriggerEnter_C(Collider other)
//     {
//         smartNavigator_C.setActive(true);
//         // Debug.Log("Object Entered the trigger");
//     }


//     // checking to see if an object is in the current zone
//     void OnTriggerStay(Collider other) 
//     {
//         // Debug.log("Object is wihtin trigger");
//     }

//     // checking to see if an object has left the current zone
//     void OnTriggerExit(Collider other) 
//     {
//         // Debug.log("Object Exited the trigger");

//     }


//     // Start is called before the first frame update
//     void Start()
//     {

//         controller.selectAction.action.started += Grab;
//         controller.selectAction.action.canceled += Release;

//         // interactable = this.GetComponent<Interactable>();

//         // determining if a object is grabbed 
//         List<InputDevice> devices = new List<InputDevice>();
//         InputDevices.GetDevices(devices);

//         foreach (var item in devices) {
//             // print the input objects
//             Debug.Log(item.name + item.characteristics);
//         }
    
//     }

//     // Update is called once per frame
//     void Update()
//     {

//         // if (interactable != null )
//         // {

//         //     isGrabbed = true;
//         // }
        
//     }

//     // private void Grab(InputAction.CallbackContext context)
//     // {
//         // grabbing a object
//     // }
   
//     // private void SuccessfullyPickedUp(GameObject pickedUpGO)
//     // {
//     //     if(OnPickedUp != null)
//     //     {
//     //         HasObject = true;
//     //         OnPickedUp(pickedUpGO, null);
//     //     }
//     // }

//     // private void OnLetGo()
//     // {
//     //     if(OnLetGo != null)
//     //     {
//     //         HasObject = false;
//     //         OnLetGo(this, null);
//     //         }
//     //     }
// }

