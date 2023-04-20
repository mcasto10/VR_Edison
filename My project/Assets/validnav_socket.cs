
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class validnav_socket : XRSocketInteractor
{
    public openclose_smartnav clampController;

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect(interactable);
    }
}