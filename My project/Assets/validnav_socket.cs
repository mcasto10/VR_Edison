using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class validnav_socket : XRSocketInteractor
{
    public XRSocketInteractor poleSocket;
    public GameObject navObject;

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        // Check if the interactable is the nav object and if it is attached to the pole socket
       
        if (interactable != null  && navObject.transform.parent == poleSocket.attachTransform.parent)
        {
            navObject.transform.SetParent(null);
            navObject.transform.position = attachTransform.position;
            return true;
        }
        return false;
    }
}

