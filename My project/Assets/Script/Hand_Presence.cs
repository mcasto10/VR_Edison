// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.XR;

// animation at min 16

// public class Hand_Presence : MonoBehaviour {
//     // min 10, don't know what he did with the controlls
//     public List<GameObject> controllerPrefabs;

//     public InputDeviceCharactersitic controllerCharacteristics;
//     // spawn controller that is used by the user
//     private GameObject spawnedController;
//     private InputDevice targetDevice;
//     // choose wheather to choose hands or not 
//     public bool showController = false; 

//     // variable for hands 
//     public GameObject handModelPrefab;
//     // spawned hands in the game 
//     private GameObject spawnHandModel;


   
//     void Start() {
//         // Creating list to store all the devices, headset, control, etc
//         List<InputDevice> devices = new List<InputDevice>();
//         // getting any device 
//         // InputDevice.getDevices(devices);

//         // getting the left controller
//         // InputDeviceCharactersitic rightControllerCharacteristics = InputDeviceCharactersitic.Right | InputDeviceCharactersitic.Controller;
//         InputDevice.getDevicesWithCharacteristics(controllerCharacteristics, devices);

//         // browsing all the devices 
//         foreach (var item in devices) {
//             // getting a sepcific devices based on the response 
//             // Debug.Log(item.name + item.characteristics);            
//         }

    //     // making sure there is a left controller
    //     if (devices.Count > 0) {
    //         // getting the controller from list we want to listen, in this case right controller
    //         targetDevice = devices[0];
            
    //         // getting the controller that is used by the user 
    //         GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);

    //         if(prefab) {
    //             // 
    //             spawnedController = Instantiate(prefab, transform);
    //          }

    //          // error message will appear if the controller the user is using is not part of the list of controllers we have in the List 
    //          else {
    //             Debug.LogError("Did not find corresponding controller model");
    //             spawnedController = Instantiate(controllerPrefabs[0], transform);
    //          }

    //          spawnHandModel= Instantiate(handModelPrefab, transform);

    //     }

    // }

    // Update is called once per frame
    // void Update() {
        // first parameter: button we want to listen to 
        // second parameter: either 0 or 1 for button clicked, float for trigger, and Vector for axis  
        // targetDevice.TryGetFeatureValue()

        // testing if the primary button was clicked
        // out button will be modified inside the function, and we could use it afterwards
        // if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButtton, out bool primaryButtonValue) && primaryButtonValue) {
            // Debug.Log("Pressing Primary Button");
        // }

        // testing if the trigger button was clicked
        // out button will be modified inside the function, and we could use it afterwards
        // if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue) && triggerValue > 0.1f) {
            // Debug.Log("Trigger pressed " + triggerValue);
        // }

         // testing if the primary feature is clicked
        // out button will be modified inside the function, and we could use it afterwards
        // if (targetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 primary2DAxisValue) && primary2DAxisValue != Vector2.zero) {
            // Debug.Log("Primary Touchpad " + primary2DAxisValue);
        // }

//         if (showController) {
//             spawnHandModel.SetActive(false);
//             spawnHandModel.SetActive(true);
//         }

//         else {
//             spawnHandModel.SetActive(true);
//             spawnedController.SetActive(false);
//         }
        
//     }
// }
