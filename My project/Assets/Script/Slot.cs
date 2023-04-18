using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Slot: MonoBehaviour {
    public GameObject ItemInSlot; 
    public Image slotImage;
    Color originalColor;

    private XRGrabInteractable grabInteractable = null;


void Start() {
    slotImage = GetComponentInChildren<Image>(); 
    originalColor = slotImage.color;  
}
    private void OnTriggerStay (Collider other) {
        if (ItemInSlot != null) return;
        GameObject obj = other.gameObject;
        if (!IsItem(obj)) return;

        // Debug.Log( obj.GetComponent<Item>().ToString());
        //  Debug.Log( obj.ToString());

        grabInteractable = GetComponent<XRGrabInteractable>();
        // grabInteractable.deactivated.AddListener(OnRelease);    
        // object has been released at the collision zone
        grabInteractable.onDeactivate.AddListener(OnRelease);


        // if (OVRInput.GetUp (OVRInput.Button. SecondaryHandTrigger))
        // {
        // InsertItem(obj);
        // }
    }

    void OnRelease(XRBaseInteractor interactor)
    {
        GameObject obj = interactor.selectTarget.gameObject;
        Debug.Log("Slot has been entered ");
        Debug.Log( obj.ToString());
        obj.GetComponent<Rigidbody>().isKinematic = true; 
        obj.transform. SetParent (gameObject.transform, true); 
        obj.transform. localPosition = Vector3.zero;
        obj.transform.localEulerAngles= obj.GetComponent<Item>().slotRotation; 
        obj.GetComponent<Item>().inSlot = true;
        obj.GetComponent<Item>().currentSlot = this;
        ItemInSlot = obj;
        slotImage.color = Color.gray;
        

    }

    

bool IsItem (GameObject obj) {
        return obj.GetComponent<Item>();
}

// void InsertItem(GameObject obj) {
//         Debug.Log("Slot has been entered ");
//         obj.GetComponent<Rigidbody>().isKinematic = true; 
//         obj.transform. SetParent (gameObject.transform, true); 
//         obj.transform. localPosition = Vector3.zero;
//         obj.transform.localEulerAngles= obj.GetComponent<Item>().slotRotation; 
//         obj.GetComponent<Item>().inSlot = true;
//         obj.GetComponent<Item>().currentSlot = this;
//         ItemInSlot = obj;
//         slotImage.color = Color.gray;
// }

public void ResetColor() {
    slotImage.color = originalColor;
        }

// bool XRControllerInput()
//     {
//         // Check for input on the secondary hand trigger
//         bool secondaryHandTriggerPressed = false;
//         secondaryHandTriggerPressed = Input.GetButtonUp("SecondaryHandTrigger");

//         return secondaryHandTriggerPressed;
//     }
}